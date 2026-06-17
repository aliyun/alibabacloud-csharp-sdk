// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetDropTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetDropTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetDropTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The number of sessions dropped by access control list (ACL) rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("AclDrop")]
            [Validation(Required=false)]
            public long? AclDrop { get; set; }

            /// <summary>
            /// <para>The current time point. The time is in the <c>YYYY-MM-DD HH:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-25 12:00:00</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <para>The ratio of dropped sessions to total sessions for this data point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DropRatio")]
            [Validation(Required=false)]
            public string DropRatio { get; set; }

            /// <summary>
            /// <para>The number of dropped sessions for the corresponding data point in the previous cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DropRing")]
            [Validation(Required=false)]
            public long? DropRing { get; set; }

            /// <summary>
            /// <para>The drop ratio for the corresponding data point in the previous cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DropRingRatio")]
            [Validation(Required=false)]
            public string DropRingRatio { get; set; }

            /// <summary>
            /// <para>The number of dropped sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("DropSession")]
            [Validation(Required=false)]
            public long? DropSession { get; set; }

            /// <summary>
            /// <para>The number of sessions dropped by the intrusion prevention system (IPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("IpsDrop")]
            [Validation(Required=false)]
            public long? IpsDrop { get; set; }

            /// <summary>
            /// <para>The corresponding time point in the previous cycle. The time is in the <c>YYYY-MM-DD HH:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-25 12:00:00</para>
            /// </summary>
            [NameInMap("RingDataTime")]
            [Validation(Required=false)]
            public string RingDataTime { get; set; }

            /// <summary>
            /// <para>The timestamp for the corresponding data point in the previous cycle. This value is a Unix timestamp that represents the number of seconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724982259</para>
            /// </summary>
            [NameInMap("RingTime")]
            [Validation(Required=false)]
            public long? RingTime { get; set; }

            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659405600</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The total number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalSession")]
            [Validation(Required=false)]
            public long? TotalSession { get; set; }

        }

        /// <summary>
        /// <para>The peak number of dropped sessions in the specified period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8090</para>
        /// </summary>
        [NameInMap("DropSessionMax")]
        [Validation(Required=false)]
        public long? DropSessionMax { get; set; }

        /// <summary>
        /// <para>The average drop ratio for the entire query period, expressed as a percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.34</para>
        /// </summary>
        [NameInMap("RatioAverage")]
        [Validation(Required=false)]
        public string RatioAverage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The average drop ratio from the previous cycle, expressed as a percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.23</para>
        /// </summary>
        [NameInMap("RingRatioAverage")]
        [Validation(Required=false)]
        public string RingRatioAverage { get; set; }

    }

}
