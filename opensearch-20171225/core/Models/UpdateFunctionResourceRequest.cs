// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateFunctionResourceRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateFunctionResourceRequestData Data { get; set; }
        public class UpdateFunctionResourceRequestData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Generators")]
            [Validation(Required=false)]
            public List<UpdateFunctionResourceRequestDataGenerators> Generators { get; set; }
            public class UpdateFunctionResourceRequestDataGenerators : TeaModel {
                [NameInMap("Generator")]
                [Validation(Required=false)]
                public string Generator { get; set; }

                [NameInMap("Input")]
                [Validation(Required=false)]
                public UpdateFunctionResourceRequestDataGeneratorsInput Input { get; set; }
                public class UpdateFunctionResourceRequestDataGeneratorsInput : TeaModel {
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public List<UpdateFunctionResourceRequestDataGeneratorsInputFeatures> Features { get; set; }
                    public class UpdateFunctionResourceRequestDataGeneratorsInputFeatures : TeaModel {
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

    }

}
