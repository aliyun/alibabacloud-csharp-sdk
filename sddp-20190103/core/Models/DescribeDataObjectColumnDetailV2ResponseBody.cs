// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectColumnDetailV2ResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataObjectColumnDetailV2ResponseBodyItems> Items { get; set; }
        public class DescribeDataObjectColumnDetailV2ResponseBodyItems : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("ColumnComment")]
            [Validation(Required=false)]
            public string ColumnComment { get; set; }

            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeDataObjectColumnDetailV2ResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeDataObjectColumnDetailV2ResponseBodyItemsModelTags : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public bool? PrimaryKey { get; set; }

            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
