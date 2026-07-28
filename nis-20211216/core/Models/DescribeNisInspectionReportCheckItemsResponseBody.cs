// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportCheckItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of check items.</para>
        /// </summary>
        [NameInMap("CheckItemList")]
        [Validation(Required=false)]
        public List<DescribeNisInspectionReportCheckItemsResponseBodyCheckItemList> CheckItemList { get; set; }
        public class DescribeNisInspectionReportCheckItemsResponseBodyCheckItemList : TeaModel {
            /// <summary>
            /// <para>The category of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stability</para>
            /// </summary>
            [NameInMap("CategoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// <para>The code of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item_nat_water_level_check</para>
            /// </summary>
            [NameInMap("CheckItemCode")]
            [Validation(Required=false)]
            public string CheckItemCode { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NAT high-availability deployment check</para>
            /// </summary>
            [NameInMap("CheckItemName")]
            [Validation(Required=false)]
            public string CheckItemName { get; set; }

            /// <summary>
            /// <para>The list of check results that indicates the number of risks at each risk level.</para>
            /// </summary>
            [NameInMap("CheckResultList")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListCheckResultList> CheckResultList { get; set; }
            public class DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListCheckResultList : TeaModel {
                /// <summary>
                /// <para>The number of risks at the specified risk level in the inspection report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>HighRisk</b></para>
                /// </description></item>
                /// <item><description><para><b>MediumRisk</b></para>
                /// </description></item>
                /// <item><description><para><b>LowRisk</b></para>
                /// </description></item>
                /// <item><description><para><b>NoRisk</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LowRisk</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
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

            /// <summary>
            /// <para>The list of results for abnormal check items.</para>
            /// </summary>
            [NameInMap("RecommendationList")]
            [Validation(Required=false)]
            public List<DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListRecommendationList> RecommendationList { get; set; }
            public class DescribeNisInspectionReportCheckItemsResponseBodyCheckItemListRecommendationList : TeaModel {
                /// <summary>
                /// <para>The description of the abnormal item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Multiple cross-zone resources share a single NAT gateway.</para>
                /// </summary>
                [NameInMap("Abnormality")]
                [Validation(Required=false)]
                public string Abnormality { get; set; }

                /// <summary>
                /// <para>The metadata of the resource that corresponds to the abnormal item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Columns&quot;:[{&quot;ColumnType&quot;:&quot;id&quot;,&quot;ColumnTitle&quot;:&quot;Resource ID&quot;,&quot;ColumnValue&quot;:&quot;ResourceId&quot;},{&quot;ColumnType&quot;:&quot;az&quot;,&quot;ColumnTitle&quot;:&quot;NAT Deployment Zone&quot;,&quot;ColumnValue&quot;:&quot;NatAZ&quot;},{&quot;ColumnType&quot;:&quot;array.az&quot;,&quot;ColumnTitle&quot;:&quot;Resource Deployment Zone&quot;,&quot;ColumnValue&quot;:&quot;ForwardsAZs&quot;},{&quot;ColumnType&quot;:&quot;region&quot;,&quot;ColumnTitle&quot;:&quot;Region&quot;,&quot;ColumnValue&quot;:&quot;RegionNo&quot;}]}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                /// <summary>
                /// <para>The cause of the abnormality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Multiple cross-zone resources share a single NAT gateway.</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// <para>The inspection item is abnormal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nat_snat_cross_az_warn</para>
                /// </summary>
                [NameInMap("RecommendationCode")]
                [Validation(Required=false)]
                public string RecommendationCode { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>HighRisk</b></para>
                /// </description></item>
                /// <item><description><para><b>MediumRisk</b></para>
                /// </description></item>
                /// <item><description><para><b>LowRisk</b></para>
                /// </description></item>
                /// <item><description><para><b>NoRisk</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LowRisk</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The optimization suggestions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deploy NAT gateways in all zones where resources reside.</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                [NameInMap("SuggestionCode")]
                [Validation(Required=false)]
                public string SuggestionCode { get; set; }

            }

            /// <summary>
            /// <para>The resource type associated with the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NAT</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nir-ffd1af****196d0</para>
        /// </summary>
        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hKrS+MVXkuOgztXnvdml194Cz/lMNdmr+DEh0th6dVlNEo/F148UPCh2itDku7Qj</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5E98683-355B-5867-8D3D-A24755F6895B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
