// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricParamDef : TeaModel {
        /// <summary>
        /// <para>输入框的最大宽度，仅对SELECT_PARAM、INPUT_PARAM生效</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("maxWidth")]
        [Validation(Required=false)]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// <para>输入框的最小宽度，仅对SELECT_PARAM、INPUT_PARAM生效</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("minWidth")]
        [Validation(Required=false)]
        public int? MinWidth { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>仅对INPUT_PARAM有效。用于前端展示的中文展位符</para>
        /// 
        /// <b>Example:</b>
        /// <para>请输入值</para>
        /// </summary>
        [NameInMap("placeholderCn")]
        [Validation(Required=false)]
        public string PlaceholderCn { get; set; }

        /// <summary>
        /// <para>仅对INPUT_PARAM有效。用于前端展示的英文展位符</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enter value</para>
        /// </summary>
        [NameInMap("placeholderEn")]
        [Validation(Required=false)]
        public string PlaceholderEn { get; set; }

        /// <summary>
        /// <para>● TEXT_PARAM: 只读文本参数，由后台定义，前端不显示用户输入控件
        /// ● INPUT_PARAM：输入框参数
        /// ● SELECT_PARAM：选择框参数</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT_PARAM</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>值</para>
        /// 
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>仅对SELECT_PARAM有效。  下拉列表的可选值列表。</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricParamDefValues> Values { get; set; }
        public class AlertRuleAlertMetricParamDefValues : TeaModel {
            /// <summary>
            /// <para>选项的中文显示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试环境</para>
            /// </summary>
            [NameInMap("labelCn")]
            [Validation(Required=false)]
            public string LabelCn { get; set; }

            /// <summary>
            /// <para>选项的英文显示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>Staging</para>
            /// </summary>
            [NameInMap("labelEn")]
            [Validation(Required=false)]
            public string LabelEn { get; set; }

            /// <summary>
            /// <para>值</para>
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
