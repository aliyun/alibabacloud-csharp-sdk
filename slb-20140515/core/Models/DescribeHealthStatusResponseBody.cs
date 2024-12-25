// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend servers.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public DescribeHealthStatusResponseBodyBackendServers BackendServers { get; set; }
        public class DescribeHealthStatusResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<DescribeHealthStatusResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class DescribeHealthStatusResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// <para>The frontend port that is used by the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// <para>The backend port that is used by the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The frontend protocol that is used by the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The health status of the backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>normal: The backend server is healthy.</description></item>
                /// <item><description>abnormal: The backend server is unhealthy.</description></item>
                /// <item><description>unavailable: The health check is not completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>abnormal</para>
                /// </summary>
                [NameInMap("ServerHealthStatus")]
                [Validation(Required=false)]
                public string ServerHealthStatus { get; set; }

                /// <summary>
                /// <para>The ID of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1h5u3fv54ytf***</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The IP address of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.XX.XX.11</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
