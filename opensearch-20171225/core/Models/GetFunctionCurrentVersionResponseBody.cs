// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionCurrentVersionResponseBody : TeaModel {
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
        public GetFunctionCurrentVersionResponseBodyResult Result { get; set; }
        public class GetFunctionCurrentVersionResponseBodyResult : TeaModel {
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
            public GetFunctionCurrentVersionResponseBodyResultVersionConfig VersionConfig { get; set; }
            public class GetFunctionCurrentVersionResponseBodyResultVersionConfig : TeaModel {
                [NameInMap("CreateParameters")]
                [Validation(Required=false)]
                public List<GetFunctionCurrentVersionResponseBodyResultVersionConfigCreateParameters> CreateParameters { get; set; }
                public class GetFunctionCurrentVersionResponseBodyResultVersionConfigCreateParameters : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public string Required { get; set; }

                }

                [NameInMap("Depends")]
                [Validation(Required=false)]
                public List<GetFunctionCurrentVersionResponseBodyResultVersionConfigDepends> Depends { get; set; }
                public class GetFunctionCurrentVersionResponseBodyResultVersionConfigDepends : TeaModel {
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
                public List<GetFunctionCurrentVersionResponseBodyResultVersionConfigUsageParameters> UsageParameters { get; set; }
                public class GetFunctionCurrentVersionResponseBodyResultVersionConfigUsageParameters : TeaModel {
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
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
