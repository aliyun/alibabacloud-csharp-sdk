// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAllRootVariableResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAllRootVariableResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAllRootVariableResponseBodyResultObject : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("displayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            [NameInMap("favoriteFlag")]
            [Validation(Required=false)]
            public bool? FavoriteFlag { get; set; }

            [NameInMap("fieldRank")]
            [Validation(Required=false)]
            public long? FieldRank { get; set; }

            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("inputFieldType")]
            [Validation(Required=false)]
            public string InputFieldType { get; set; }

            [NameInMap("inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outputThreshold")]
            [Validation(Required=false)]
            public DescribeAllRootVariableResponseBodyResultObjectOutputThreshold OutputThreshold { get; set; }
            public class DescribeAllRootVariableResponseBodyResultObjectOutputThreshold : TeaModel {
                [NameInMap("maxValue")]
                [Validation(Required=false)]
                public double? MaxValue { get; set; }

                [NameInMap("minValue")]
                [Validation(Required=false)]
                public double? MinValue { get; set; }

            }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
