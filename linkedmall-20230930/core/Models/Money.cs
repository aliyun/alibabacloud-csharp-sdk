// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Money : TeaModel {
        /// <summary>
        /// <para>amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>amountAsString</para>
        /// </summary>
        [NameInMap("amountAsString")]
        [Validation(Required=false)]
        public string AmountAsString { get; set; }

        /// <summary>
        /// <para>amountString</para>
        /// </summary>
        [NameInMap("amountString")]
        [Validation(Required=false)]
        public string AmountString { get; set; }

        /// <summary>
        /// <para>cent</para>
        /// 
        /// <b>Example:</b>
        /// <para>12800</para>
        /// </summary>
        [NameInMap("cent")]
        [Validation(Required=false)]
        public long? Cent { get; set; }

        /// <summary>
        /// <para>currency</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public MoneyCurrency Currency { get; set; }
        public class MoneyCurrency : TeaModel {
            /// <summary>
            /// <para>currencyCode</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("currencyCode")]
            [Validation(Required=false)]
            public string CurrencyCode { get; set; }

            /// <summary>
            /// <para>defaultFractionDigits</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("defaultFractionDigits")]
            [Validation(Required=false)]
            public int? DefaultFractionDigits { get; set; }

            /// <summary>
            /// <para>displayName</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>numericCode</para>
            /// 
            /// <b>Example:</b>
            /// <para>156</para>
            /// </summary>
            [NameInMap("numericCode")]
            [Validation(Required=false)]
            public int? NumericCode { get; set; }

            /// <summary>
            /// <para>symbol</para>
            /// 
            /// <b>Example:</b>
            /// <para>￥</para>
            /// </summary>
            [NameInMap("symbol")]
            [Validation(Required=false)]
            public string Symbol { get; set; }

        }

        /// <summary>
        /// <para>currencyCode</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("currencyCode")]
        [Validation(Required=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// <para>positive</para>
        /// </summary>
        [NameInMap("positive")]
        [Validation(Required=false)]
        public bool? Positive { get; set; }

    }

}
