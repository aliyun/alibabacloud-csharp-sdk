// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartTerminalSessionRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The value of <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command to run after the session is initiated. The command can be up to 512 characters in length.</para>
        /// <remarks>
        /// <para>After you specify CommandLine, you cannot specify PortNumber or TargetServer.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ssh <a href="mailto:root@192.168.0.246">root@192.168.0.246</a></para>
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// <para>The network type of the WebSocket URL for the remote connection to the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Internet: public network. This is the default value.</description></item>
        /// <item><description>Intranet: internal network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The session encryption configuration.</para>
        /// </summary>
        [NameInMap("EncryptionOptions")]
        [Validation(Required=false)]
        public StartTerminalSessionRequestEncryptionOptions EncryptionOptions { get; set; }
        public class StartTerminalSessionRequestEncryptionOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable end-to-end encryption for the session connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The KMS key ID.
            /// Note:</para>
            /// <list type="bullet">
            /// <item><description>Only KMS symmetric keys are supported.</description></item>
            /// <item><description>This parameter is supported only when the encryption mode is set to Kms.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The encryption pattern. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto: uses an automatically negotiated secret key encryption for the session.</description></item>
            /// <item><description>Kms: uses a KMS secret key encryption for the session.</description></item>
            /// <item><description>Default value: Auto.</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only when session encryption is enabled.</description></item>
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
        /// <para>The instance ID list.</para>
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
        /// <para>The name of the password used by the user when using Session Manager on a Windows instance. The name can be up to 255 characters in length.
        /// When you want to use Session Manager on a Windows instance as a non-default user (System), you must specify both Username and this parameter. To reduce the risk of password leaks, store the plaintext password in the parameter repository of operations management and specify only the password name here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encryption parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("PasswordName")]
        [Validation(Required=false)]
        public string PasswordName { get; set; }

        /// <summary>
        /// <para>The port number of the ECS instance for data forwarding. After this parameter is set, Cloud Assistant Agent forwards data to the specified port for port forwarding. For example, SSH uses port 22.</para>
        /// <para>Default value: empty, which indicates that no port number is set for data forwarding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("PortNumber")]
        [Validation(Required=false)]
        public int? PortNumber { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent list of regions.</para>
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
        /// <para>The address of the destination server in the VPC that you want to access through the instance.</para>
        /// <remarks>
        /// <para>When this parameter is not empty, PortNumber specifies the port number of the destination server in the VPC that you want to access through the managed instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.246</para>
        /// </summary>
        [NameInMap("TargetServer")]
        [Validation(Required=false)]
        public string TargetServer { get; set; }

        /// <summary>
        /// <para>The username used for the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
