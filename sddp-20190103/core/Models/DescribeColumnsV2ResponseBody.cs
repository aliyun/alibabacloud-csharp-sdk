// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsV2ResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeColumnsV2ResponseBodyItems> Items { get; set; }
        public class DescribeColumnsV2ResponseBodyItems : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeColumnsV2ResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeColumnsV2ResponseBodyItemsModelTags : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            [NameInMap("OdpsRiskLevelValue")]
            [Validation(Required=false)]
            public int? OdpsRiskLevelValue { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("RevisionId")]
            [Validation(Required=false)]
            public long? RevisionId { get; set; }

            [NameInMap("RevisionStatus")]
            [Validation(Required=false)]
            public long? RevisionStatus { get; set; }

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

            [NameInMap("SensLevelName")]
            [Validation(Required=false)]
            public string SensLevelName { get; set; }

            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            [NameInMap("TableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

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
