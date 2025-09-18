// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartTerminalSessionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The command to run after the session is initiated. The command length cannot exceed 512 characters.</para>
        /// <remarks>
        /// <para> If you specify the <c>CommandLine</c> parameter, you cannot specify the <c>PortNumber</c> or <c>TargetServer</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ssh <a href="mailto:root@192.168.0.246">root@192.168.0.246</a></para>
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// <para>The network type of the WebSocket URL required to connect to the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Internet (default)</description></item>
        /// <item><description>Intranet</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        [NameInMap("EncryptionOptions")]
        [Validation(Required=false)]
        public string EncryptionOptionsShrink { get; set; }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PasswordName")]
        [Validation(Required=false)]
        public string PasswordName { get; set; }

        /// <summary>
        /// <para>The port number of the ECS instance. The port is used to forward data. After this parameter is configured, Cloud Assistant Agent forwards data to the specified port. For example, you can set this parameter to 22 for data forwarding over SSH.</para>
        /// <para>This parameter is empty by default, which indicates that no port is configured to forward data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("PortNumber")]
        [Validation(Required=false)]
        public int? PortNumber { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IP address of the instance. You can use the IP address to access the destination service in a virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para> If this parameter is not empty, <c>PortNumber</c> specifies the port number that is used by the managed instance to access the destination service in the VPC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.246</para>
        /// </summary>
        [NameInMap("TargetServer")]
        [Validation(Required=false)]
        public string TargetServer { get; set; }

        /// <summary>
        /// <para>The username used for connection establishment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
