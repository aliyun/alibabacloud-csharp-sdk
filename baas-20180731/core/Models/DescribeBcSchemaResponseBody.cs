// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeBcSchemaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeBcSchemaResponseBodyResult Result { get; set; }
        public class DescribeBcSchemaResponseBodyResult : TeaModel {
            [NameInMap("Responses")]
            [Validation(Required=false)]
            public List<DescribeBcSchemaResponseBodyResultResponses> Responses { get; set; }
            public class DescribeBcSchemaResponseBodyResultResponses : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public DescribeBcSchemaResponseBodyResultResponsesProperties Properties { get; set; }
                public class DescribeBcSchemaResponseBodyResultResponsesProperties : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public List<DescribeBcSchemaResponseBodyResultResponsesPropertiesDataSource> DataSource { get; set; }
                    public class DescribeBcSchemaResponseBodyResultResponsesPropertiesDataSource : TeaModel {
                        [NameInMap("AllowNull")]
                        [Validation(Required=false)]
                        public int? AllowNull { get; set; }

                        [NameInMap("Annotation")]
                        [Validation(Required=false)]
                        public string Annotation { get; set; }

                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                        [NameInMap("Indexes")]
                        [Validation(Required=false)]
                        public int? Indexes { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public int? Key { get; set; }

                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public int? Length { get; set; }

                        [NameInMap("Reg")]
                        [Validation(Required=false)]
                        public string Reg { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

            }

            [NameInMap("Schema")]
            [Validation(Required=false)]
            public DescribeBcSchemaResponseBodyResultSchema Schema { get; set; }
            public class DescribeBcSchemaResponseBodyResultSchema : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

        }

    }

}
