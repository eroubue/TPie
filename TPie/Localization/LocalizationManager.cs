using System.Collections.Generic;
using System.Globalization;

namespace TPie.Localization
{
    public static class LocalizationManager
    {
        private static Dictionary<string, string> _translations = new Dictionary<string, string>();
        private static string _currentLanguage = "en";

        public static void Initialize()
        {
            // 检测系统语言
            var culture = CultureInfo.CurrentCulture;
            if (culture.Name.StartsWith("zh-CN") || culture.Name.StartsWith("zh-Hans"))
            {
                SetLanguage("zh-CN");
            }
            else
            {
                SetLanguage("en");
            }
        }

        public static void SetLanguage(string languageCode)
        {
            _currentLanguage = languageCode;
            LoadTranslations();
        }

        private static void LoadTranslations()
        {
            _translations.Clear();

            if (_currentLanguage == "zh-CN")
            {
                LoadChineseTranslations();
            }
            // 英文作为默认语言，不需要加载额外的翻译
        }

        private static void LoadChineseTranslations()
        {
            _translations = new Dictionary<string, string>
            {
                // Window Titles
                {"TPie Settings", "TPie 设置"},
                {"Ring Settings", "环形菜单设置"},
                {"Edit Action", "编辑技能"},
                {"Edit Item", "编辑物品"},
                {"Edit Gear Set", "编辑套装"},
                {"Edit Emote", "编辑表情"},
                {"Edit Command", "编辑指令"},
                {"Edit Game Macro", "编辑游戏宏"},
                {"Edit Nested Ring", "编辑嵌套环形菜单"},
                {"Icon Picker", "图标选择器"},
                {"Edit Keybind", "编辑快捷键"},

                // Tab Names
                {"General", "常规"},
                {"Global Border Settings", "全局边框设置"},
                {"Rings", "环形菜单"},

                // Position Section
                {"Position", "位置"},
                {"Center at Cursor", "光标居中"},
                {"Set Position", "设置位置"},
                {"Center Cursor", "居中光标"},
                {"(0,0) is the center of the screen", "(0,0) 是屏幕中心"},
                {"Your cursor will automatically move to the center of the ring when activated.", "激活时光标将自动移动到环形菜单中心。"},

                // Font Section
                {"Font", "字体"},
                {"Use Custom Font", "使用自定义字体"},
                {"Enable to use the Expressway font that comes with TPie.\nDisable to use the system font.", "启用使用 TPie 内置的 Expressway 字体。\n禁用则使用系统字体。"},
                {"Size", "大小"},

                // Keybinds Section
                {"Keybinds", "快捷键"},
                {"Keybind", "快捷键"},
                {"Keybind Passthrough", "快捷键穿透"},
                {"When enabled, TPie wont prevent the game from receiving a key press asssigned for a ring.", "启用时，TPie 不会阻止游戏接收分配给环形菜单的按键。"},
                {"Enable Quick Settings", "启用快速设置"},
                {"When enabled, double right-clicking when a ring is opened will open the settings for that ring.", "启用时，在环形菜单打开时双击右键将打开该环形菜单的设置。"},
                {"Enable Escape key to close rings", "启用 Escape 键关闭环形菜单"},
                {"When enabled, pressing the Escape key while a ring with a toggable keybind is opened will immediately close it.", "启用时，在带有可切换快捷键的环形菜单打开时按 Escape 键将立即关闭它。"},

                // Style Section
                {"Style", "样式"},
                {"Draw Rings Background", "绘制环形菜单背景"},
                {"Resize Icons When Hovered", "悬停时调整图标大小"},
                {"Show Cooldowns", "显示冷却时间"},
                {"Show Remaining Item Count", "显示剩余物品数量"},

                // Animation Section
                {"Animation", "动画"},
                {"Duration", "持续时间"},
                {"In seconds", "秒"},
                {"None", "无"},
                {"Spiral", "螺旋"},
                {"Sequential", "顺序"},
                {"Fade", "淡入淡出"},

                // Global Border Settings
                {"These are the default border settings that will be used when creating a new ring element.", "这些是创建新环形菜单元素时使用的默认边框设置。"},
                {"Apply to all existing elements", "应用到所有现有元素"},
                {"Apply?", "应用？"},
                {"Are you sure you want to apply these border settings to all existing elements?", "您确定要将这些边框设置应用到所有现有元素吗？"},
                {"There is no way to undo this!", "此操作无法撤销！"},

                // Rings Tab Actions
                {"Create New", "新建"},
                {"Adds a new empty Ring", "添加一个新的空环形菜单"},
                {"Import", "导入"},
                {"Adds new Rings by importing them from the clipboard", "从剪贴板导入新的环形菜单"},
                {"Export all", "导出全部"},
                {"Exports all Rings to the clipboard", "将所有环形菜单导出到剪贴板"},

                // Table Headers
                {"Color", "颜色"},
                {"Name", "名称"},
                {"Actions", "操作"},
                {"Move", "移动"},
                {"Type", "类型"},
                {"Icon", "图标"},
                {"Description", "描述"},
                {"Quick Action", "快速操作"},

                // Common Actions
                {"Add", "添加"},
                {"Edit", "编辑"},
                {"Delete", "删除"},
                {"Move up", "上移"},
                {"Move down", "下移"},
                {"Edit Elements", "编辑元素"},
                {"Export to clipboard", "导出到剪贴板"},
                {"Delete?", "删除？"},

                // Ring Settings
                {"Radius", "半径"},
                {"Rotation", "旋转"},
                {"Items Size", "物品大小"},
                {"Line", "线条"},
                {"Selection Background", "选择背景"},
                {"Tooltips", "工具提示"},
                {"This will show a tooltip with a description of an element when hovering on top of it.", "悬停在元素上时将显示包含元素描述的工具提示。"},
                {"Only execute actions on click", "仅在点击时执行操作"},
                {"When enabled, hovering on a item and closing the ring will not execute the hovered action.", "启用时，悬停在物品上并关闭环形菜单不会执行悬停的操作。"},

                // Element Types
                {"Action", "技能"},
                {"Item", "物品"},
                {"Gear Set", "套装"},
                {"Command", "指令"},
                {"Game Macro", "游戏宏"},
                {"Emote", "表情"},
                {"Nested Ring", "嵌套环形菜单"},

                // Element Configuration
                {"ID or Name", "ID 或名称"},
                {"In Inventory", "在背包中"},
                {"High Quality", "高品质"},
                {"Icon ID", "图标 ID"},
                {"Reset to default", "重置为默认"},
                {"Search", "搜索"},
                {"Draw Text", "绘制文字"},
                {"Only When Selected", "仅在选中时"},
                {"Acquired", "已获得"},

                // Gear Set Specific
                {"Use Set Number", "使用套装编号"},
                {"Use Set Name", "使用套装名称"},
                {"Gear Set Number", "套装编号"},
                {"Gear Set Name", "套装名称"},
                {"Your gear set name should start with this (case sensitive)", "您的套装名称应以此开头（区分大小写）"},
                {"Job", "职业"},

                // Game Macro Specific
                {"ID", "ID"},
                {"Shared", "共享"},

                // Nested Ring Specific
                {"Ring Name", "环形菜单名称"},
                {"Click to Activate", "点击激活"},
                {"Hover to Activate", "悬停激活"},
                {"Activation Time", "激活时间"},
                {"Determines how many seconds the element needs to be hovered on to activate the nested ring.", "确定元素需要悬停多少秒才能激活嵌套环形菜单。"},
                {"Keep Previous Ring Center", "保持上一个环形菜单中心"},

                // Icon Browser
                {"Browse", "浏览"},
                {"Key Item", "重要物品"},
                {"Mount", "坐骑"},
                {"Companion", "宠物"},

                // Keybind Window
                {"Toggleable", "可切换"},
                {"When enabled, this keybind will behave as a toggle instead of \"press and hold\".\nOn this mode, once an item is selected, you can either press the keybind again or just click to activate it.", "启用时，此快捷键将表现为切换而不是\"按住\"。\n在此模式下，选择物品后，您可以再次按快捷键或直接点击来激活它。"},
                {"Use for all jobs", "用于所有职业"},
                {"Use for specific jobs:", "用于特定职业："},
                {"Role", "职业分类"},
                {"All", "全部"},
                {"Backspace to clear", "退格键清除"},

                // Validation Messages
                {"This action won't show on the current Job.", "此技能不会在当前职业显示。"},
                {"This item won't show if it's not in your inventory.", "如果不在背包中，此物品将不会显示。"},
                {"Command format invalid", "指令格式无效"},
                {"New Command", "新指令"},

                // Dialog Buttons
                {"OK", "确定"},
                {"Cancel", "取消"},

                // Support
                {"Support on Ko-fi", "在爱发电上支持零师傅"},

                // Command Description
                {"Opens the TPie configuration window.", "打开 TPie 配置窗口。"},

                // Keybind Modifiers
                {"Ctrl + ", "Ctrl + "},
                {"Alt + ", "Alt + "},
                {"Shift + ", "Shift + "},

                // Additional strings
                {"These are the default border settings that will be", "这些是创建新环形菜单元素时"},
                {"used when creating a new ring element.", "使用的默认边框设置。"},
                {"Are you sure you want to apply these border", "您确定要将这些边框设置"},
                {"settings to all existing elements?", "应用到所有现有元素吗？"},
                {"Are you sure you want to delete \"{0}\"?", "您确定要删除 \"{0}\" 吗？"}
            };
        }

        public static string GetText(string key)
        {
            if (_translations.ContainsKey(key))
            {
                return _translations[key];
            }
            return key; // 如果没有找到翻译，返回原文
        }

        public static string T(string key)
        {
            return GetText(key);
        }
    }
}