// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricParamDef : TeaModel {
        /// <summary>
        /// <para>The maximum width of the input box, which applies only to SELECT_PARAM and INPUT_PARAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("maxWidth")]
        [Validation(Required=false)]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// <para>The minimum width of the input box, which applies only to SELECT_PARAM and INPUT_PARAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("minWidth")]
        [Validation(Required=false)]
        public int? MinWidth { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Chinese placeholder for frontend display, which applies only to INPUT_PARAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请输入值</para>
        /// </summary>
        [NameInMap("placeholderCn")]
        [Validation(Required=false)]
        public string PlaceholderCn { get; set; }

        /// <summary>
        /// <para>The English placeholder for frontend display, which applies only to INPUT_PARAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enter value</para>
        /// </summary>
        [NameInMap("placeholderEn")]
        [Validation(Required=false)]
        public string PlaceholderEn { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TEXT_PARAM: Read-only text parameter defined by the backend. No user input control is displayed on the frontend.</description></item>
        /// <item><description>INPUT_PARAM: Input box parameter.</description></item>
        /// <item><description>SELECT_PARAM: Selection box parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT_PARAM</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The list of selectable values for the drop-down list, which applies only to SELECT_PARAM.</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricParamDefValues> Values { get; set; }
        public class AlertRuleAlertMetricParamDefValues : TeaModel {
            /// <summary>
            /// <para>The Chinese display name of the option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试环境</para>
            /// </summary>
            [NameInMap("labelCn")]
            [Validation(Required=false)]
            public string LabelCn { get; set; }

            /// <summary>
            /// <para>The English display name of the option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Staging</para>
            /// </summary>
            [NameInMap("labelEn")]
            [Validation(Required=false)]
            public string LabelEn { get; set; }

            /// <summary>
            /// <para>The value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>staging</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
