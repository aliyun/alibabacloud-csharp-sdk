// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusAlertTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("PrometheusAlertTemplates")]
        [Validation(Required=false)]
        public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplates> PrometheusAlertTemplates { get; set; }
        public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplates : TeaModel {
            /// <summary>
            /// <para>The name of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The available memory on the node is less than 10%</para>
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// <para>The annotations of the alert rule.</para>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesAnnotations> Annotations { get; set; }
            public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesAnnotations : TeaModel {
                /// <summary>
                /// <para>The name of the annotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>message</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the annotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The available memory on node {{ $labels.instance }} is less than 10%. Available memory: {{ $value }}%</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The content of the alert notification. Tags can be referenced in the {{$labels.xxx}} format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The available memory on node {{ $labels.instance }} is less than 10%. Available memory: {{ $value }}%</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration of the alert. Valid values: 1 to 1440. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1m</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The expression of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_memory_MemAvailable_bytes / node_memory_MemTotal_bytes * 100 &lt; 10</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The tags of the alert rule.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesLabels> Labels { get; set; }
            public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesLabels : TeaModel {
                /// <summary>
                /// <para>The name of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>severity</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FEA6D00-317F-45E3-9004-7FB8B0B7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
