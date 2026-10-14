// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHealthCheckStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details of the health status of the origin server.</para>
        /// </summary>
        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckStatusResponseBodyHealthCheckStatus> HealthCheckStatus { get; set; }
        public class DescribeHealthCheckStatusResponseBodyHealthCheckStatus : TeaModel {
            /// <summary>
            /// <para>The forwarding port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-mp91j1ao****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The forwarding protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>An array that consists of the health states of the IP addresses of the origin server.</para>
            /// </summary>
            [NameInMap("RealServerStatusList")]
            [Validation(Required=false)]
            public List<DescribeHealthCheckStatusResponseBodyHealthCheckStatusRealServerStatusList> RealServerStatusList { get; set; }
            public class DescribeHealthCheckStatusResponseBodyHealthCheckStatusRealServerStatusList : TeaModel {
                /// <summary>
                /// <para>The IP address of the origin server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The health state of the IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: healthy</description></item>
                /// <item><description><b>abnormal</b>: unhealthy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>abnormal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The health status of the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: healthy</description></item>
            /// <item><description><b>abnormal</b>: unhealthy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE9FF9E1-569C-4B6C-AB6A-0F6D927BB27C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
