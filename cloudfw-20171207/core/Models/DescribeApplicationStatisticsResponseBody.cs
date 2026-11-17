// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeApplicationStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application counts grouped by application category.</para>
        /// </summary>
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public List<DescribeApplicationStatisticsResponseBodyCategoryList> CategoryList { get; set; }
        public class DescribeApplicationStatisticsResponseBodyCategoryList : TeaModel {
            /// <summary>
            /// <para>The number of applications in the application category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ApplicationCount")]
            [Validation(Required=false)]
            public long? ApplicationCount { get; set; }

            /// <summary>
            /// <para>The name of the application category. The name is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office collaboration</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of application counts grouped by risk level.</para>
        /// </summary>
        [NameInMap("RiskList")]
        [Validation(Required=false)]
        public List<DescribeApplicationStatisticsResponseBodyRiskList> RiskList { get; set; }
        public class DescribeApplicationStatisticsResponseBodyRiskList : TeaModel {
            /// <summary>
            /// <para>The number of applications at the risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ApplicationCount")]
            [Validation(Required=false)]
            public long? ApplicationCount { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Information</b>: Informational.</description></item>
            /// <item><description><b>Low</b>: Low.</description></item>
            /// <item><description><b>Medium</b>: Medium.</description></item>
            /// <item><description><b>High</b>: High.</description></item>
            /// <item><description><b>Critical</b>: Critical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Low</para>
            /// </summary>
            [NameInMap("Risk")]
            [Validation(Required=false)]
            public string Risk { get; set; }

        }

        /// <summary>
        /// <para>The list of application counts grouped by technology type.</para>
        /// </summary>
        [NameInMap("TechnologyList")]
        [Validation(Required=false)]
        public List<DescribeApplicationStatisticsResponseBodyTechnologyList> TechnologyList { get; set; }
        public class DescribeApplicationStatisticsResponseBodyTechnologyList : TeaModel {
            /// <summary>
            /// <para>The number of applications of the technology type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ApplicationCount")]
            [Validation(Required=false)]
            public long? ApplicationCount { get; set; }

            /// <summary>
            /// <para>The name of the technology type. The name is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Browser-based</para>
            /// </summary>
            [NameInMap("Technology")]
            [Validation(Required=false)]
            public string Technology { get; set; }

        }

    }

}
