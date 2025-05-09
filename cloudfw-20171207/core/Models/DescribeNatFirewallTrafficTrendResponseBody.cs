// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics on traffic.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeNatFirewallTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The maximum inbound network throughput, which indicates the maximum number of bits that are sent inbound per second. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18038632</para>
            /// </summary>
            [NameInMap("MaxInBps")]
            [Validation(Required=false)]
            public long? MaxInBps { get; set; }

            /// <summary>
            /// <para>The maximum outbound network throughput, which indicates the maximum number of bits that are sent outbound per second. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122596487</para>
            /// </summary>
            [NameInMap("MaxOutBps")]
            [Validation(Required=false)]
            public long? MaxOutBps { get; set; }

            /// <summary>
            /// <para>The total maximum inbound and outbound network throughput, which indicates the maximum number of bits that are sent inbound and outbound per second. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66953194</para>
            /// </summary>
            [NameInMap("MaxTotalBps")]
            [Validation(Required=false)]
            public long? MaxTotalBps { get; set; }

            /// <summary>
            /// <para>The time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1734418980</para>
            /// </summary>
            [NameInMap("TrafficTime")]
            [Validation(Required=false)]
            public long? TrafficTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum inbound network throughput, which indicates the maximum number of bits that are sent inbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18038632</para>
        /// </summary>
        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        /// <summary>
        /// <para>The maximum outbound network throughput, which indicates the maximum number of bits that are sent outbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122596487</para>
        /// </summary>
        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        /// <summary>
        /// <para>The total maximum inbound and outbound network throughput, which indicates the maximum number of bits that are sent inbound and outbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66953194</para>
        /// </summary>
        [NameInMap("MaxTotalBps")]
        [Validation(Required=false)]
        public long? MaxTotalBps { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>87F23A3A-6F57-59C3-8237-A090D0613D71</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
