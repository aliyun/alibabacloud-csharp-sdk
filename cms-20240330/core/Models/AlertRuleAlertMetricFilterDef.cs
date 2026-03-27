// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricFilterDef : TeaModel {
        /// <summary>
        /// <para>Dimension in APM metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status</para>
        /// </summary>
        [NameInMap("dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        /// <summary>
        /// <para>When true, the filter item will not appear in the GROUP BY clause of the PromQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dimDisabled")]
        [Validation(Required=false)]
        public bool? DimDisabled { get; set; }

        /// <summary>
        /// <para>Display Name (Chinese).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application Status</para>
        /// </summary>
        [NameInMap("displayNameCn")]
        [Validation(Required=false)]
        public string DisplayNameCn { get; set; }

        /// <summary>
        /// <para>Display Name (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application Status</para>
        /// </summary>
        [NameInMap("displayNameEn")]
        [Validation(Required=false)]
        public string DisplayNameEn { get; set; }

        /// <summary>
        /// <para>Whether to hide. If hidden, it will not be displayed in the frontend UI, but its value can still be included when rendering the PromQL. A typical example is the &quot;pid&quot; filter condition in APM scenarios, which is generally not exposed through configurable UI elements but instead presented as a separate application search list in the frontend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>When true, the filter item will not appear in the label filter of the PromQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("labelDisabled")]
        [Validation(Required=false)]
        public bool? LabelDisabled { get; set; }

        /// <summary>
        /// <para>Filter Condition Operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=</para>
        /// </summary>
        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        /// <summary>
        /// <para>List of supported options.</para>
        /// </summary>
        [NameInMap("supportedOpts")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricFilterDefSupportedOpts> SupportedOpts { get; set; }
        public class AlertRuleAlertMetricFilterDefSupportedOpts : TeaModel {
            /// <summary>
            /// <para>Display Name (Chinese).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("displayNameCn")]
            [Validation(Required=false)]
            public string DisplayNameCn { get; set; }

            /// <summary>
            /// <para>Display Name (English).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("displayNameEn")]
            [Validation(Required=false)]
            public string DisplayNameEn { get; set; }

            /// <summary>
            /// <para>Matching value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
