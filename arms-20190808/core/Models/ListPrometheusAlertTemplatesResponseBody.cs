// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusAlertTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PrometheusAlertTemplates")]
        [Validation(Required=false)]
        public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplates> PrometheusAlertTemplates { get; set; }
        public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplates : TeaModel {
            /// <summary>
            /// The name of the alert rule.
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// The annotations of the alert rule.
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesAnnotations> Annotations { get; set; }
            public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesAnnotations : TeaModel {
                /// <summary>
                /// The name of the annotation.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the annotation.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The content of the alert notification. Tags can be referenced in the {{$labels.xxx}} format.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The duration of the alert. Valid values: 1 to 1440. Unit: minutes.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The expression of the alert rule.
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// The tags of the alert rule.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesLabels> Labels { get; set; }
            public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesLabels : TeaModel {
                /// <summary>
                /// The name of the tag.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of the alert rule.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The version of the alert rule.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
