// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionVersionResponseBody : TeaModel {
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
        public GetFunctionVersionResponseBodyResult Result { get; set; }
        public class GetFunctionVersionResponseBodyResult : TeaModel {
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public GetFunctionVersionResponseBodyResultVersionConfig VersionConfig { get; set; }
            public class GetFunctionVersionResponseBodyResultVersionConfig : TeaModel {
                [NameInMap("CreateParameters")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigCreateParameters> CreateParameters { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigCreateParameters : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public string Required { get; set; }

                }

                [NameInMap("Depends")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigDepends> Depends { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigDepends : TeaModel {
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    [NameInMap("Dependency")]
                    [Validation(Required=false)]
                    public string Dependency { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                }

                [NameInMap("UsageParameters")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigUsageParameters> UsageParameters { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigUsageParameters : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public string Required { get; set; }

                }

            }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
