// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricFilterDef : TeaModel {
        /// <summary>
        /// <para>The dimension in APM metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status</para>
        /// </summary>
        [NameInMap("dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the dimension. If set to true, the filter item does not appear in the group by clause of PromQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dimDisabled")]
        [Validation(Required=false)]
        public bool? DimDisabled { get; set; }

        /// <summary>
        /// <para>The Chinese display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>应用状态</para>
        /// </summary>
        [NameInMap("displayNameCn")]
        [Validation(Required=false)]
        public string DisplayNameCn { get; set; }

        /// <summary>
        /// <para>The English display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application Status</para>
        /// </summary>
        [NameInMap("displayNameEn")]
        [Validation(Required=false)]
        public string DisplayNameEn { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the filter. If hidden, the filter is not displayed in frontend interactions, but its value can be passed when rendering PromQL. A typical example is the pid filter in APM scenarios, which is typically not displayed through configuration but shown as a separate application search list in the frontend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the label. If set to true, the filter item does not appear in the label filter of PromQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("labelDisabled")]
        [Validation(Required=false)]
        public bool? LabelDisabled { get; set; }

        /// <summary>
        /// <para>The filter condition operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=</para>
        /// </summary>
        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        /// <summary>
        /// <para>The list of supported options.</para>
        /// </summary>
        [NameInMap("supportedOpts")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricFilterDefSupportedOpts> SupportedOpts { get; set; }
        public class AlertRuleAlertMetricFilterDefSupportedOpts : TeaModel {
            /// <summary>
            /// <para>The Chinese display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>在线</para>
            /// </summary>
            [NameInMap("displayNameCn")]
            [Validation(Required=false)]
            public string DisplayNameCn { get; set; }

            /// <summary>
            /// <para>The English display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("displayNameEn")]
            [Validation(Required=false)]
            public string DisplayNameEn { get; set; }

            /// <summary>
            /// <para>The match value.</para>
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
