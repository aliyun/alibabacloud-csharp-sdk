// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailV2ResponseBody : TeaModel {
        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailV2ResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetail : TeaModel {
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleList : TeaModel {
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

                [NameInMap("RiskLevelName")]
                [Validation(Required=false)]
                public string RiskLevelName { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
