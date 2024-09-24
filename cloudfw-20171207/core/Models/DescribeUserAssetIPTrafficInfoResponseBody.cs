// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAssetIPTrafficInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656923760</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The network throughput, which indicates the inbound traffic rate. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4520</para>
        /// </summary>
        [NameInMap("InBps")]
        [Validation(Required=false)]
        public long? InBps { get; set; }

        /// <summary>
        /// <para>The inbound network throughput, which indicates the number of packets that are sent inbound per second. Unit: packets per second (pps).</para>
        /// 
        /// <b>Example:</b>
        /// <para>233</para>
        /// </summary>
        [NameInMap("InPps")]
        [Validation(Required=false)]
        public long? InPps { get; set; }

        /// <summary>
        /// <para>The new connection creation rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("NewConn")]
        [Validation(Required=false)]
        public long? NewConn { get; set; }

        /// <summary>
        /// <para>The network throughput, which indicates the outbound traffic rate. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4180</para>
        /// </summary>
        [NameInMap("OutBps")]
        [Validation(Required=false)]
        public long? OutBps { get; set; }

        /// <summary>
        /// <para>The outbound network throughput, which indicates the number of packets that are sent outbound per second. Unit: pps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224</para>
        /// </summary>
        [NameInMap("OutPps")]
        [Validation(Required=false)]
        public long? OutPps { get; set; }

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
        /// <para>The number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("SessionCount")]
        [Validation(Required=false)]
        public long? SessionCount { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
