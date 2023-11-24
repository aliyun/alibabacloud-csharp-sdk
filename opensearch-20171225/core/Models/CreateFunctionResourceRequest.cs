// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFunctionResourceRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateFunctionResourceRequestData Data { get; set; }
        public class CreateFunctionResourceRequestData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Generators")]
            [Validation(Required=false)]
            public List<CreateFunctionResourceRequestDataGenerators> Generators { get; set; }
            public class CreateFunctionResourceRequestDataGenerators : TeaModel {
                [NameInMap("Generator")]
                [Validation(Required=false)]
                public string Generator { get; set; }

                [NameInMap("Input")]
                [Validation(Required=false)]
                public CreateFunctionResourceRequestDataGeneratorsInput Input { get; set; }
                public class CreateFunctionResourceRequestDataGeneratorsInput : TeaModel {
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public List<CreateFunctionResourceRequestDataGeneratorsInputFeatures> Features { get; set; }
                    public class CreateFunctionResourceRequestDataGeneratorsInputFeatures : TeaModel {
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

        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
