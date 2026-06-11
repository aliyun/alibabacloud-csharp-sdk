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
        /// <para>If set to \<c>true\\</c>, the filter item does not appear in the \<c>group by\\</c> clause of a PromQL query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dimDisabled")]
        [Validation(Required=false)]
        public bool? DimDisabled { get; set; }

        /// <summary>
        /// <para>The display name in Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>应用状态</para>
        /// </summary>
        [NameInMap("displayNameCn")]
        [Validation(Required=false)]
        public string DisplayNameCn { get; set; }

        /// <summary>
        /// <para>The display name in English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application Status</para>
        /// </summary>
        [NameInMap("displayNameEn")]
        [Validation(Required=false)]
        public string DisplayNameEn { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the filter. If hidden, the filter does not appear in the frontend UI. However, its value can be uploaded when rendering a PromQL query. For example, in an Application Performance Management (APM) scenario, the pid filter is typically hidden from the configuration UI. The frontend displays it as a separate application search list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>If set to \<c>true\\</c>, the filter item does not appear in the label filter of a PromQL query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("labelDisabled")]
        [Validation(Required=false)]
        public bool? LabelDisabled { get; set; }

        /// <summary>
        /// <para>The operator for the filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=</para>
        /// </summary>
        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        /// <summary>
        /// <para>A list of supported options.</para>
        /// </summary>
        [NameInMap("supportedOpts")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricFilterDefSupportedOpts> SupportedOpts { get; set; }
        public class AlertRuleAlertMetricFilterDefSupportedOpts : TeaModel {
            /// <summary>
            /// <para>The display name in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>在线</para>
            /// </summary>
            [NameInMap("displayNameCn")]
            [Validation(Required=false)]
            public string DisplayNameCn { get; set; }

            /// <summary>
            /// <para>The display name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("displayNameEn")]
            [Validation(Required=false)]
            public string DisplayNameEn { get; set; }

            /// <summary>
            /// <para>The matching value.</para>
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
