// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionRecommendationResourcesResponseBody : TeaModel {
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
        /// <para>The maximum number of entries returned on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qt0DqY2lXxwBt9/ROQoS/7J9p90D1vF2vFbwzb/1oSWr3AxcM6/KpObZ7Z1PZdcV</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<DescribeNisInspectionRecommendationResourcesResponseBodyResourceList> ResourceList { get; set; }
        public class DescribeNisInspectionRecommendationResourcesResponseBodyResourceList : TeaModel {
            /// <summary>
            /// <para>The details of the abnormal item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ResourceId: &quot;ngw-p0wn04hi4****q2us6q7q&quot;}</para>
            /// </summary>
            [NameInMap("AnalysisData")]
            [Validation(Required=false)]
            public string AnalysisData { get; set; }

            /// <summary>
            /// <para>The ID of the abnormal instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-p0wn04hi4****q2us6q7q</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public NAT gateway</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

        }

        /// <summary>
        /// <para>The total number of resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
