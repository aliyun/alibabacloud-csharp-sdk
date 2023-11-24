// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionResourcesResponseBody : TeaModel {
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
        public List<ListFunctionResourcesResponseBodyResult> Result { get; set; }
        public class ListFunctionResourcesResponseBodyResult : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListFunctionResourcesResponseBodyResultData Data { get; set; }
            public class ListFunctionResourcesResponseBodyResultData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Generators")]
                [Validation(Required=false)]
                public List<ListFunctionResourcesResponseBodyResultDataGenerators> Generators { get; set; }
                public class ListFunctionResourcesResponseBodyResultDataGenerators : TeaModel {
                    [NameInMap("Generator")]
                    [Validation(Required=false)]
                    public string Generator { get; set; }

                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public ListFunctionResourcesResponseBodyResultDataGeneratorsInput Input { get; set; }
                    public class ListFunctionResourcesResponseBodyResultDataGeneratorsInput : TeaModel {
                        [NameInMap("Features")]
                        [Validation(Required=false)]
                        public List<ListFunctionResourcesResponseBodyResultDataGeneratorsInputFeatures> Features { get; set; }
                        public class ListFunctionResourcesResponseBodyResultDataGeneratorsInputFeatures : TeaModel {
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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
