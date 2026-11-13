// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeApplicationStatisticsResponseBody : TeaModel {
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public List<DescribeApplicationStatisticsResponseBodyCategoryList> CategoryList { get; set; }
        public class DescribeApplicationStatisticsResponseBodyCategoryList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ApplicationCount")]
            [Validation(Required=false)]
            public long? ApplicationCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>办公协作</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskList")]
        [Validation(Required=false)]
        public List<DescribeApplicationStatisticsResponseBodyRiskList> RiskList { get; set; }
        public class DescribeApplicationStatisticsResponseBodyRiskList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ApplicationCount")]
            [Validation(Required=false)]
            public long? ApplicationCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Low</para>
            /// </summary>
            [NameInMap("Risk")]
            [Validation(Required=false)]
            public string Risk { get; set; }

        }

        [NameInMap("TechnologyList")]
        [Validation(Required=false)]
        public List<DescribeApplicationStatisticsResponseBodyTechnologyList> TechnologyList { get; set; }
        public class DescribeApplicationStatisticsResponseBodyTechnologyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ApplicationCount")]
            [Validation(Required=false)]
            public long? ApplicationCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>基于浏览器</para>
            /// </summary>
            [NameInMap("Technology")]
            [Validation(Required=false)]
            public string Technology { get; set; }

        }

    }

}
