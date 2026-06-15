// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartTerminalSessionRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a unique parameter value from your client to guarantee uniqueness across different requests. <b>ClientToken</b> supports only ASCII characters and must not exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command to run after the session is initiated. The command length cannot exceed 512 characters.</para>
        /// <remarks>
        /// <para>If you specify the <c>CommandLine</c> parameter, you cannot specify the <c>PortNumber</c> or <c>TargetServer</c> parameter.</para>
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
        /// <item><description><para>Internet (default)</para>
        /// </description></item>
        /// <item><description><para>Intranet</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>Session encryption configuration items.</para>
        /// </summary>
        [NameInMap("EncryptionOptions")]
        [Validation(Required=false)]
        public StartTerminalSessionRequestEncryptionOptions EncryptionOptions { get; set; }
        public class StartTerminalSessionRequestEncryptionOptions : TeaModel {
            /// <summary>
            /// <para>Enable end-to-end encryption for the session connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>KMS key ID.<br>
            /// Notes:</para>
            /// <list type="bullet">
            /// <item><description><para>Only KMS symmetric keys are supported.</para>
            /// </description></item>
            /// <item><description><para>This parameter can be specified only when the encryption mode is Kms.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>Encryption mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Auto: Use autonegotiation to encrypt the session with a secret key.</para>
            /// </description></item>
            /// <item><description><para>Kms: Use a KMS key to encrypt the session.</para>
            /// </description></item>
            /// <item><description><para>Default value: Auto.</para>
            /// </description></item>
            /// </list>
            /// <para>Notes:</para>
            /// <list type="bullet">
            /// <item><description>This parameter can be specified only when session encryption is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

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

        /// <summary>
        /// <para>The password name of the user when using Session Manager on a Windows instance. The length cannot exceed 255 characters.<br>
        /// When you want to use Session Manager on a Windows instance as a non-default user (System), you must pass both Username and this parameter. To reduce the risk of password disclosure, store the plaintext password in the parameter repository of CloudOps Orchestration Service, and pass only the password name here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">encrypted parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
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
        /// <para>If this parameter is not empty, <c>PortNumber</c> specifies the port number that is used by the managed instance to access the destination service in the VPC.</para>
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
