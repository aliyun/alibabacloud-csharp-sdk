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
            /// <summary>
            /// <b>Example:</b>
            /// <para>stability</para>
            /// </summary>
            [NameInMap("CategoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_nat_water_level_check</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>item_ep_high_availability_check_description</para>
            /// </summary>
            [NameInMap("DescriptionCode")]
            [Validation(Required=false)]
            public string DescriptionCode { get; set; }

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

                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nat_snat_cross_az_warn</para>
                /// </summary>
                [NameInMap("RecommendationCode")]
                [Validation(Required=false)]
                public string RecommendationCode { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                [NameInMap("SuggestionCode")]
                [Validation(Required=false)]
                public string SuggestionCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NAT</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nir-ffd1af****196d0</para>
        /// </summary>
        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hKrS+MVXkuOgztXnvdml194Cz/lMNdmr+DEh0th6dVlNEo/F148UPCh2itDku7Qj</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D5E98683-355B-5867-8D3D-A24755F6895B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
