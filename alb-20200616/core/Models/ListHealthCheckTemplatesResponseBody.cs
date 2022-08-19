// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListHealthCheckTemplatesResponseBody : TeaModel {
        [NameInMap("HealthCheckTemplates")]
        [Validation(Required=false)]
        public List<ListHealthCheckTemplatesResponseBodyHealthCheckTemplates> HealthCheckTemplates { get; set; }
        public class ListHealthCheckTemplatesResponseBodyHealthCheckTemplates : TeaModel {
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }

            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            [NameInMap("HealthCheckTemplateId")]
            [Validation(Required=false)]
            public string HealthCheckTemplateId { get; set; }

            [NameInMap("HealthCheckTemplateName")]
            [Validation(Required=false)]
            public string HealthCheckTemplateName { get; set; }

            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
