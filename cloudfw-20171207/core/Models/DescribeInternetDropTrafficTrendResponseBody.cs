// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetDropTrafficTrendResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetDropTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetDropTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("AclDrop")]
            [Validation(Required=false)]
            public long? AclDrop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-08-25 12:00:00</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DropRatio")]
            [Validation(Required=false)]
            public string DropRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DropRing")]
            [Validation(Required=false)]
            public long? DropRing { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DropRingRatio")]
            [Validation(Required=false)]
            public string DropRingRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("DropSession")]
            [Validation(Required=false)]
            public long? DropSession { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("IpsDrop")]
            [Validation(Required=false)]
            public long? IpsDrop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-08-25 12:00:00</para>
            /// </summary>
            [NameInMap("RingDataTime")]
            [Validation(Required=false)]
            public string RingDataTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1724982259</para>
            /// </summary>
            [NameInMap("RingTime")]
            [Validation(Required=false)]
            public long? RingTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1659405600</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalSession")]
            [Validation(Required=false)]
            public long? TotalSession { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8090</para>
        /// </summary>
        [NameInMap("DropSessionMax")]
        [Validation(Required=false)]
        public long? DropSessionMax { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12.34</para>
        /// </summary>
        [NameInMap("RatioAverage")]
        [Validation(Required=false)]
        public string RatioAverage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.23</para>
        /// </summary>
        [NameInMap("RingRatioAverage")]
        [Validation(Required=false)]
        public string RingRatioAverage { get; set; }

    }

}
