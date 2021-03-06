﻿namespace Kapitalist.Data.Models.Consts
{
    /// <summary>
    /// Можливі значення для переговорних процедур negotiation та negotiation.quick
    /// </summary>
    public static class NegotiationCause
    {
        /// <summary>
        /// cт. 35, п. 1
        /// Закупівля творів мистецтва або закупівля, пов’язана із захистом прав інтелектуальної власності,
        /// або укладення договору про закупівлю з переможцем архітектурного чи мистецького конкурсу.
        /// </summary>
        public const string ART_CONTEST_IP = "artContestIP";

        /// <summary>
        /// cт. 35, п. 2
        /// Відсутність конкуренції (у тому числі з технічних причин) на відповідному ринку,
        /// внаслідок чого договір про закупівлю може бути укладено лише з одним постачальником,
        /// за відсутності при цьому альтернативи.
        /// </summary>
        public const string NO_COMPETITION = "noCompetition";

        /// <summary>
        /// cт. 35, п. 4
        /// Якщо замовником було двічі відмінено тендер через відсутність достатньої кількості учасників,
        /// при цьому предмет закупівлі, його технічні та якісні характеристики,
        /// а також вимоги до учасника не повинні відрізнятися від вимог, що були визначені замовником у тедерній документації.
        /// </summary>
        public const string TWICE_UNSUCCESSFUL = "twiceUnsuccessful";

        /// <summary>
        /// cт. 35, п. 5
        /// Потреба здійснити додаткову закупівлю в того самого постачальника з метою уніфікації,
        /// стандартизації або забезпечення сумісності з наявними товарами, технологіями, роботами чи послугами,
        /// якщо заміна попереднього постачальника (виконавця робіт, надавача послуг) може призвести до несумісності
        /// або виникнення проблем технічного характеру, пов’язаних з експлуатацією та обслуговуванням.
        /// </summary>
        public const string ADDITIONAL_PURCHASE = "additionalPurchase";

        /// <summary>
        /// cт. 35, п. 6
        /// Необхідність проведення додаткових будівельних робіт, не зазначених у початковому проекті,
        /// але які стали через непередбачувані обставини необхідними для виконання проекту за сукупності таких умов:
        /// договір буде укладено з попереднім виконавцем цих робіт, такі роботи технічно чи економічно пов’язані з головним (первинним) договором;
        /// загальна вартість додаткових робіт не перевищує 50 відсотків вартості головного (первинного) договору.
        /// </summary>
        public const string ADDITIONAL_CONSTRUCTION = "additionalConstruction";

        /// <summary>
        /// cт. 35, п. 7
        /// Закупівля юридичних послуг, пов’язаних із захистом прав та інтересів України,
        /// у тому числі з метою захисту національної безпеки і оборони, під час врегулювання спорів,
        /// розгляду в закордонних юрисдикційних органах справ за участю іноземного суб’єкта та України,
        /// на підставі рішення Кабінету Міністрів України або введених в дію відповідно до закону рішень Ради національної безпеки
        /// і оборони України.
        /// </summary>
        public const string STATE_LEGAL_SERVICE = "stateLegalServices";

        /// <summary>
        /// cт. 35, п. 3
        /// Нагальна потреба у здійсненні закупівлі у зв’язку з виникненням особливих економічних чи соціальних обставин,
        /// яка унеможливлює дотримання замовниками строків для проведення тендеру, а саме пов’язаних з негайною ліквідацією
        /// наслідків надзвичайних ситуацій, а також наданням у встановленому порядку Україною гуманітарної допомоги іншим державам.
        /// Застосування переговорної процедури закупівлі в таких випадках здійснюється за рішенням замовника щодо кожної процедури.
        /// </summary>
        public const string QUICK = "quick";
    }
}