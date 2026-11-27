// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelAreaDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The regional statistics list.</para>
        /// </summary>
        [NameInMap("AreaStatList")]
        [Validation(Required=false)]
        public List<DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList> AreaStatList { get; set; }
        public class DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList : TeaModel {
            /// <summary>
            /// <para>The region name, such as China_Zhejiang Province_Hangzhou.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China_Zhejiang Province_Hangzhou</para>
            /// </summary>
            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            /// <summary>
            /// <para>The number of communicating users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CallUserCount")]
            [Validation(Required=false)]
            public int? CallUserCount { get; set; }

            /// <summary>
            /// <para>The high-quality transmission rate, represented as a decimal. For example, 0.9999 indicates a high-quality transmission rate of 99.99%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9999</para>
            /// </summary>
            [NameInMap("HighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string HighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <para>The number of publishers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PubUserCount")]
            [Validation(Required=false)]
            public int? PubUserCount { get; set; }

            /// <summary>
            /// <para>The number of subscribers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubUserCount")]
            [Validation(Required=false)]
            public int? SubUserCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
