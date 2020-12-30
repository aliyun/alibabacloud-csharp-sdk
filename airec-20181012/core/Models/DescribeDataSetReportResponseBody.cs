// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeDataSetReportResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDataSetReportResponseBodyResult Result { get; set; }
        public class DescribeDataSetReportResponseBodyResult : TeaModel {
            [NameInMap("Overall")]
            [Validation(Required=false)]
            public DescribeDataSetReportResponseBodyResultOverall Overall { get; set; }
            public class DescribeDataSetReportResponseBodyResultOverall : TeaModel {
                [NameInMap("UserRepetitiveRate")]
                [Validation(Required=false)]
                public float? UserRepetitiveRate { get; set; }

                [NameInMap("UserUserCount")]
                [Validation(Required=false)]
                public int? UserUserCount { get; set; }

                [NameInMap("BhvCount")]
                [Validation(Required=false)]
                public int? BhvCount { get; set; }

                [NameInMap("BhvLegalRate")]
                [Validation(Required=false)]
                public float? BhvLegalRate { get; set; }

                [NameInMap("UserCompleteRate")]
                [Validation(Required=false)]
                public float? UserCompleteRate { get; set; }

                [NameInMap("UserLoginRate")]
                [Validation(Required=false)]
                public float? UserLoginRate { get; set; }

                [NameInMap("ItemCompleteRate")]
                [Validation(Required=false)]
                public float? ItemCompleteRate { get; set; }

                [NameInMap("ItemRepetitiveRate")]
                [Validation(Required=false)]
                public float? ItemRepetitiveRate { get; set; }

                [NameInMap("ItemItemCount")]
                [Validation(Required=false)]
                public int? ItemItemCount { get; set; }

                [NameInMap("UserLegalRate")]
                [Validation(Required=false)]
                public float? UserLegalRate { get; set; }

                [NameInMap("ItemLegalRate")]
                [Validation(Required=false)]
                public float? ItemLegalRate { get; set; }

                [NameInMap("ItemLoginRate")]
                [Validation(Required=false)]
                public float? ItemLoginRate { get; set; }

            }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeDataSetReportResponseBodyResultDetail> Detail { get; set; }
            public class DescribeDataSetReportResponseBodyResultDetail : TeaModel {
                public float? UvCtr { get; set; }
                public long? BizDate { get; set; }
                public float? PerUvClick { get; set; }
                public long? Pv { get; set; }
                public long? ActiveItem { get; set; }
                public float? Ctr { get; set; }
                public float? PerUvBhv { get; set; }
                public long? Click { get; set; }
                public long? Uv { get; set; }
                public long? ClickUser { get; set; }
            }
        };

    }

}
