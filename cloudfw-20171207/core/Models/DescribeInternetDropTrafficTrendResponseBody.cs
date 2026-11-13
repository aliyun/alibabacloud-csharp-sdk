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
            /// <para>The number of corresponding intrusion prevention events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("AclDrop")]
            [Validation(Required=false)]
            public long? AclDrop { get; set; }

            /// <summary>
            /// <para>The current time point. The time format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-25 12:00:00</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <para>The list of queried traffic points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DropRatio")]
            [Validation(Required=false)]
            public string DropRatio { get; set; }

            /// <summary>
            /// <para>The value range of the object: <b>[0,10000\]</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DropRing")]
            [Validation(Required=false)]
            public long? DropRing { get; set; }

            /// <summary>
            /// <para>The rate of network traffic. Unit: kbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DropRingRatio")]
            [Validation(Required=false)]
            public string DropRingRatio { get; set; }

            /// <summary>
            /// <para>The number of blocked sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("DropSession")]
            [Validation(Required=false)]
            public long? DropSession { get; set; }

            /// <summary>
            /// <para>The number of queried IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("IpsDrop")]
            [Validation(Required=false)]
            public long? IpsDrop { get; set; }

            /// <summary>
            /// <para>The corresponding time point in the previous period. The time format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-25 12:00:00</para>
            /// </summary>
            [NameInMap("RingDataTime")]
            [Validation(Required=false)]
            public string RingDataTime { get; set; }

            /// <summary>
            /// <para>The dynamic packet drop time. The value is a UNIX timestamp in seconds, which indicates the number of seconds that have elapsed since January 1, 1970 (UTC).</para>
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
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalSession")]
            [Validation(Required=false)]
            public long? TotalSession { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of dropped sessions in the corresponding period (peak value).</para>
        /// 
        /// <b>Example:</b>
        /// <para>8090</para>
        /// </summary>
        [NameInMap("DropSessionMax")]
        [Validation(Required=false)]
        public long? DropSessionMax { get; set; }

        /// <summary>
        /// <para>The traffic multiplication mode. Valid values: - <b>0</b>: priority mode. - <b>1</b>: load balancing mode.</para>
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
        /// <para>The traffic rate. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.23</para>
        /// </summary>
        [NameInMap("RingRatioAverage")]
        [Validation(Required=false)]
        public string RingRatioAverage { get; set; }

    }

}
