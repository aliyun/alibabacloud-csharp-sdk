// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusAlertTemplatesResponseBody : TeaModel {
        [NameInMap("PrometheusAlertTemplates")]
        [Validation(Required=false)]
        public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplates> PrometheusAlertTemplates { get; set; }
        public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplates : TeaModel {
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesAnnotations> Annotations { get; set; }
            public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesAnnotations : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesLabels> Labels { get; set; }
            public class ListPrometheusAlertTemplatesResponseBodyPrometheusAlertTemplatesLabels : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
