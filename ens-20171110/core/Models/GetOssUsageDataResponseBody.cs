// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A8CCD48-14F9-0309-B957-7B1D74A8119D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of usage data.</para>
        /// </summary>
        [NameInMap("UsageList")]
        [Validation(Required=false)]
        public List<GetOssUsageDataResponseBodyUsageList> UsageList { get; set; }
        public class GetOssUsageDataResponseBodyUsageList : TeaModel {
            /// <summary>
            /// <para>The inbound bandwidth over the internal network. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37865147</para>
            /// </summary>
            [NameInMap("LanRxBw")]
            [Validation(Required=false)]
            public long? LanRxBw { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth over the internal network. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22012187890</para>
            /// </summary>
            [NameInMap("LanTxBw")]
            [Validation(Required=false)]
            public long? LanTxBw { get; set; }

            /// <summary>
            /// <para>The number of time points within a day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>144</para>
            /// </summary>
            [NameInMap("Point")]
            [Validation(Required=false)]
            public long? Point { get; set; }

            /// <summary>
            /// <para>The point in time, in UTC. Format: 2010-01-21T09:50:23Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T00:00:00Z</para>
            /// </summary>
            [NameInMap("PointTs")]
            [Validation(Required=false)]
            public string PointTs { get; set; }

            /// <summary>
            /// <para>The storage usage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85462146217</para>
            /// </summary>
            [NameInMap("StorageUsageByte")]
            [Validation(Required=false)]
            public long? StorageUsageByte { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth over the Internet. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>542155715</para>
            /// </summary>
            [NameInMap("WanRxBw")]
            [Validation(Required=false)]
            public long? WanRxBw { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth over the Internet. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>547126175217</para>
            /// </summary>
            [NameInMap("WanTxBw")]
            [Validation(Required=false)]
            public long? WanTxBw { get; set; }

        }

    }

}
