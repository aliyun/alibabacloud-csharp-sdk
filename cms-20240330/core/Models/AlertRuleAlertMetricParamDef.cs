// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricParamDef : TeaModel {
        /// <summary>
        /// <para>The maximum width of the input control. This parameter is valid only for SELECT_PARAM and INPUT_PARAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("maxWidth")]
        [Validation(Required=false)]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// <para>The minimum width of the input control. This parameter is valid only for SELECT_PARAM and INPUT_PARAM.</para>
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
        /// <para>The Chinese placeholder text displayed on the frontend. This parameter is valid only for INPUT_PARAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请输入值</para>
        /// </summary>
        [NameInMap("placeholderCn")]
        [Validation(Required=false)]
        public string PlaceholderCn { get; set; }

        /// <summary>
        /// <para>The English placeholder text displayed on the frontend. This parameter is valid only for INPUT_PARAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enter value</para>
        /// </summary>
        [NameInMap("placeholderEn")]
        [Validation(Required=false)]
        public string PlaceholderEn { get; set; }

        /// <summary>
        /// <para>● TEXT_PARAM: A read-only text parameter defined by the backend. No user input control is displayed on the frontend.● INPUT_PARAM: An input box parameter.● SELECT_PARAM: A selection box parameter.</para>
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
        /// <para>The list of available options in the drop-down list. This parameter is valid only for SELECT_PARAM.</para>
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
