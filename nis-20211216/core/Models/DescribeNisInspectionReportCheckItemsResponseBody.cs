// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportCheckItemsResponseBody : TeaModel {
        [NameInMap("CheckItemList")]
        [Validation(Required=false)]
        public List<DescribeNisInspectionReportCheckItemsResponseBodyCheckItemList> CheckItemList { get; set; }
        public class DescribeNisInspectionReportCheckItemsResponseBodyCheckItemList : TeaModel {
            [NameInMap("CategoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            [NameInMap("CheckItemCode")]
            [Validation(Required=false)]
            public string CheckItemCode { get; set; }

            [NameInMap("CheckItemName")]
            [Validation(Required=false)]
            public string CheckItemName { get; set; }

            [NameInMap("CheckResultList")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListCheckResultList> CheckResultList { get; set; }
            public class DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListCheckResultList : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("RecommendationList")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListRecommendationList> RecommendationList { get; set; }
            public class DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListRecommendationList : TeaModel {
                [NameInMap("Abnormality")]
                [Validation(Required=false)]
                public string Abnormality { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("RecommendationCode")]
                [Validation(Required=false)]
                public string RecommendationCode { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
