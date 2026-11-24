// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartTerminalSessionRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The command to be executed after the session is initiated. The command cannot exceed 512 characters in length.</para>
        /// <remarks>
        /// <para>After CommandLine is specified, you cannot specify PortNumber or TargetServer.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ssh <a href="mailto:root@192.168.0.246">root@192.168.0.246</a></para>
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// <para>The network type of the WebSocket URL required for a remote connection to the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Internet: the Internet. This is the default value.</description></item>
        /// <item><description>Intranet: the internal network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The session encryption configurations.</para>
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
            /// <para>The ID of the KMS key.
            /// Precautions:</para>
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
            /// <item><description>Auto: uses an automatically negotiated key to perform secret key encryption on the session.</description></item>
            /// <item><description>Kms: uses a KMS key to perform secret key encryption on the session.</description></item>
            /// <item><description>Default value: Auto.</description></item>
            /// </list>
            /// <para>Precautions:</para>
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
        /// <para>The list of instance IDs.</para>
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
        /// <para>The name of the user password used when Session Manager is used on a Windows instance. The name cannot exceed 255 characters in length.
        /// If you want to use Session Manager on a Windows instance as a non-default user (System), you must specify both the Username parameter and this parameter. To reduce the risk of password leakage, the plaintext password must be hosted in the operations management parameter repository, and only the password name is passed here. For more information, see <a href="https://help.aliyun.com/document_detail/186828.html">Encrypted parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axtSecretPassword</para>
        /// </summary>
        [NameInMap("PasswordName")]
        [Validation(Required=false)]
        public string PasswordName { get; set; }

        /// <summary>
        /// <para>The port number of the ECS instance, which is used for data forwarding. After this parameter is specified, data forwarding of Cloud Assistant Agent is directed to the specified port number for port forwarding. For example, SSH uses port 22.</para>
        /// <para>Default value: null, which indicates that the port number for data forwarding is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("PortNumber")]
        [Validation(Required=false)]
        public int? PortNumber { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
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
        /// <para>The destination service address in the VPC that is accessed through the instance.</para>
        /// <remarks>
        /// <para>When this parameter is not empty, PortNumber specifies the port number of the destination service in the VPC that is accessed through the managed instance.</para>
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
