// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of port forwarding rules.</para>
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public List<DescribePortResponseBodyNetworkRules> NetworkRules { get; set; }
        public class DescribePortResponseBodyNetworkRules : TeaModel {
            /// <summary>
            /// <para>The port of the origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("BackendPort")]
            [Validation(Required=false)]
            public int? BackendPort { get; set; }

            /// <summary>
            /// <para>The forwarding port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("FrontendProtocol")]
            [Validation(Required=false)]
            public string FrontendProtocol { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the port forwarding rule is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-7e225i41****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the port forwarding rule is automatically created by the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAutoCreate")]
            [Validation(Required=false)]
            public bool? IsAutoCreate { get; set; }

            /// <summary>
            /// <para>An array that consists of IP addresses of origin servers.</para>
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39499F01-19D9-4EA4-A0E9-C6014BA5CDBE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of port forwarding rules returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
