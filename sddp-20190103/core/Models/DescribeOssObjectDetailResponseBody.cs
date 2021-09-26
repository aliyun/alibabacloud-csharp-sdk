// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailResponseBodyOssObjectDetail : TeaModel {
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList : TeaModel {
                public string RiskLevelName { get; set; }
                public string CategoryName { get; set; }
                public long? RiskLevelId { get; set; }
                public long? Count { get; set; }
                public string RuleName { get; set; }
            }
        };

    }

}
