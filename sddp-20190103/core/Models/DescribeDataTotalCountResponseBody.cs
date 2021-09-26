// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataTotalCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public DescribeDataTotalCountResponseBodyDataCount DataCount { get; set; }
        public class DescribeDataTotalCountResponseBodyDataCount : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public DescribeDataTotalCountResponseBodyDataCountInstance Instance { get; set; }
            public class DescribeDataTotalCountResponseBodyDataCountInstance : TeaModel {
                [NameInMap("LastSensitiveCount")]
                [Validation(Required=false)]
                public long? LastSensitiveCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("LastCount")]
                [Validation(Required=false)]
                public long? LastCount { get; set; }

                [NameInMap("RiskCountList")]
                [Validation(Required=false)]
                public List<DescribeDataTotalCountResponseBodyDataCountInstanceRiskCountList> RiskCountList { get; set; }
                public class DescribeDataTotalCountResponseBodyDataCountInstanceRiskCountList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

            }
            [NameInMap("Table")]
            [Validation(Required=false)]
            public DescribeDataTotalCountResponseBodyDataCountTable Table { get; set; }
            public class DescribeDataTotalCountResponseBodyDataCountTable : TeaModel {
                [NameInMap("LastSensitiveCount")]
                [Validation(Required=false)]
                public long? LastSensitiveCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("LastCount")]
                [Validation(Required=false)]
                public long? LastCount { get; set; }

                [NameInMap("RiskCountList")]
                [Validation(Required=false)]
                public List<DescribeDataTotalCountResponseBodyDataCountTableRiskCountList> RiskCountList { get; set; }
                public class DescribeDataTotalCountResponseBodyDataCountTableRiskCountList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

            }
            [NameInMap("Package")]
            [Validation(Required=false)]
            public DescribeDataTotalCountResponseBodyDataCountPackage Package { get; set; }
            public class DescribeDataTotalCountResponseBodyDataCountPackage : TeaModel {
                [NameInMap("LastSensitiveCount")]
                [Validation(Required=false)]
                public long? LastSensitiveCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("LastCount")]
                [Validation(Required=false)]
                public long? LastCount { get; set; }

                [NameInMap("RiskCountList")]
                [Validation(Required=false)]
                public List<DescribeDataTotalCountResponseBodyDataCountPackageRiskCountList> RiskCountList { get; set; }
                public class DescribeDataTotalCountResponseBodyDataCountPackageRiskCountList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

            }
            [NameInMap("Column")]
            [Validation(Required=false)]
            public DescribeDataTotalCountResponseBodyDataCountColumn Column { get; set; }
            public class DescribeDataTotalCountResponseBodyDataCountColumn : TeaModel {
                [NameInMap("LastSensitiveCount")]
                [Validation(Required=false)]
                public long? LastSensitiveCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("LastCount")]
                [Validation(Required=false)]
                public long? LastCount { get; set; }

                [NameInMap("RiskCountList")]
                [Validation(Required=false)]
                public List<DescribeDataTotalCountResponseBodyDataCountColumnRiskCountList> RiskCountList { get; set; }
                public class DescribeDataTotalCountResponseBodyDataCountColumnRiskCountList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                [NameInMap("ColumnRuleTop")]
                [Validation(Required=false)]
                public List<DescribeDataTotalCountResponseBodyDataCountColumnColumnRuleTop> ColumnRuleTop { get; set; }
                public class DescribeDataTotalCountResponseBodyDataCountColumnColumnRuleTop : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

            }
            [NameInMap("Oss")]
            [Validation(Required=false)]
            public DescribeDataTotalCountResponseBodyDataCountOss Oss { get; set; }
            public class DescribeDataTotalCountResponseBodyDataCountOss : TeaModel {
                [NameInMap("LastSensitiveCount")]
                [Validation(Required=false)]
                public long? LastSensitiveCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("LastCount")]
                [Validation(Required=false)]
                public long? LastCount { get; set; }

                [NameInMap("RiskCountList")]
                [Validation(Required=false)]
                public List<DescribeDataTotalCountResponseBodyDataCountOssRiskCountList> RiskCountList { get; set; }
                public class DescribeDataTotalCountResponseBodyDataCountOssRiskCountList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                [NameInMap("OssRuleTop")]
                [Validation(Required=false)]
                public List<DescribeDataTotalCountResponseBodyDataCountOssOssRuleTop> OssRuleTop { get; set; }
                public class DescribeDataTotalCountResponseBodyDataCountOssOssRuleTop : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

            }
        };

    }

}
