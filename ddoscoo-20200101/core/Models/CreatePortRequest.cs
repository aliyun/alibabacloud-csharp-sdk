// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreatePortRequest : TeaModel {
        /// <summary>
        /// <para>The port of the origin server. Valid values: <b>0</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("BackendPort")]
        [Validation(Required=false)]
        public string BackendPort { get; set; }

        /// <summary>
        /// <para>The forwarding port. Valid values: <b>0</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public string FrontendPort { get; set; }

        /// <summary>
        /// <para>The type of the forwarding protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b></description></item>
        /// <item><description><b>udp</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("FrontendProtocol")]
        [Validation(Required=false)]
        public string FrontendProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance to which the port forwarding rule belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> operation to query the IDs of all instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-st21zbyq****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ProxyEnable")]
        [Validation(Required=false)]
        public long? ProxyEnable { get; set; }

        /// <summary>
        /// <para>An array that consists of the IP addresses of origin servers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

    }

}
