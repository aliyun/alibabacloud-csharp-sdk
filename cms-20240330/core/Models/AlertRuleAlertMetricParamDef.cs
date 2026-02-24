// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricParamDef : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("maxWidth")]
        [Validation(Required=false)]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("minWidth")]
        [Validation(Required=false)]
        public int? MinWidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("placeholderCn")]
        [Validation(Required=false)]
        public string PlaceholderCn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enter value</para>
        /// </summary>
        [NameInMap("placeholderEn")]
        [Validation(Required=false)]
        public string PlaceholderEn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEXT_PARAM</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricParamDefValues> Values { get; set; }
        public class AlertRuleAlertMetricParamDefValues : TeaModel {
            [NameInMap("labelCn")]
            [Validation(Required=false)]
            public string LabelCn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Staging</para>
            /// </summary>
            [NameInMap("labelEn")]
            [Validation(Required=false)]
            public string LabelEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>staging</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
