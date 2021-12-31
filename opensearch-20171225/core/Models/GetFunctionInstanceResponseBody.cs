// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        [NameInMap("Latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionInstanceResponseBodyResult Result { get; set; }
        public class GetFunctionInstanceResponseBodyResult : TeaModel {
            [NameInMap("Belongs")]
            [Validation(Required=false)]
            public GetFunctionInstanceResponseBodyResultBelongs Belongs { get; set; }
            public class GetFunctionInstanceResponseBodyResultBelongs : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }
            [NameInMap("CreateParameters")]
            [Validation(Required=false)]
            public List<GetFunctionInstanceResponseBodyResultCreateParameters> CreateParameters { get; set; }
            public class GetFunctionInstanceResponseBodyResultCreateParameters : TeaModel {
                public string Name { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Task")]
            [Validation(Required=false)]
            public GetFunctionInstanceResponseBodyResultTask Task { get; set; }
            public class GetFunctionInstanceResponseBodyResultTask : TeaModel {
                [NameInMap("DagStatus")]
                [Validation(Required=false)]
                public string DagStatus { get; set; }

                [NameInMap("LastRunTime")]
                [Validation(Required=false)]
                public long? LastRunTime { get; set; }

            }
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
