// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionResourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        [NameInMap("Latency")]
        [Validation(Required=false)]
        public double? Latency { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionResourceResponseBodyResult Result { get; set; }
        public class GetFunctionResourceResponseBodyResult : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetFunctionResourceResponseBodyResultData Data { get; set; }
            public class GetFunctionResourceResponseBodyResultData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Generators")]
                [Validation(Required=false)]
                public List<GetFunctionResourceResponseBodyResultDataGenerators> Generators { get; set; }
                public class GetFunctionResourceResponseBodyResultDataGenerators : TeaModel {
                    [NameInMap("Generator")]
                    [Validation(Required=false)]
                    public string Generator { get; set; }

                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetFunctionResourceResponseBodyResultDataGeneratorsInput Input { get; set; }
                    public class GetFunctionResourceResponseBodyResultDataGeneratorsInput : TeaModel {
                        [NameInMap("Features")]
                        [Validation(Required=false)]
                        public List<GetFunctionResourceResponseBodyResultDataGeneratorsInputFeatures> Features { get; set; }
                        public class GetFunctionResourceResponseBodyResultDataGeneratorsInputFeatures : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("ReferencedInstances")]
            [Validation(Required=false)]
            public List<string> ReferencedInstances { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
