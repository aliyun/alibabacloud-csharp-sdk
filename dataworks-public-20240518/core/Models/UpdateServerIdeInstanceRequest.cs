// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateServerIdeInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The credential injection configuration for the instance. After this feature is enabled, you can use the default RAM role chain or specify a custom RAM role.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public UpdateServerIdeInstanceRequestCredentialConfig CredentialConfig { get; set; }
        public class UpdateServerIdeInstanceRequestCredentialConfig : TeaModel {
            /// <summary>
            /// <para>The environment variable role key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AliyunEnvRoleKey")]
            [Validation(Required=false)]
            public string AliyunEnvRoleKey { get; set; }

            /// <summary>
            /// <para>The list of credential configurations.</para>
            /// </summary>
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<UpdateServerIdeInstanceRequestCredentialConfigConfigs> Configs { get; set; }
            public class UpdateServerIdeInstanceRequestCredentialConfigConfigs : TeaModel {
                /// <summary>
                /// <para>The identifier key of the credential configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The list of roles in the credential configuration.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<UpdateServerIdeInstanceRequestCredentialConfigConfigsRoles> Roles { get; set; }
                public class UpdateServerIdeInstanceRequestCredentialConfigConfigsRoles : TeaModel {
                    /// <summary>
                    /// <para>The Alibaba Cloud account ID of the principal that assumes the role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456789012****</para>
                    /// </summary>
                    [NameInMap("AssumeRoleFor")]
                    [Validation(Required=false)]
                    public string AssumeRoleFor { get; set; }

                    /// <summary>
                    /// <para>The policy used to further restrict the role permissions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// <para>The ARN of the RAM role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::123456789012****:role/DataWorksRole</para>
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                    /// <summary>
                    /// <para>The role assumption type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>service: assumed by a service.</description></item>
                    /// <item><description>user: assumed by a user.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service</para>
                    /// </summary>
                    [NameInMap("RoleType")]
                    [Validation(Required=false)]
                    public string RoleType { get; set; }

                    /// <summary>
                    /// <para>The information of the delegated user.</para>
                    /// </summary>
                    [NameInMap("UserInfo")]
                    [Validation(Required=false)]
                    public UpdateServerIdeInstanceRequestCredentialConfigConfigsRolesUserInfo UserInfo { get; set; }
                    public class UpdateServerIdeInstanceRequestCredentialConfigConfigsRolesUserInfo : TeaModel {
                        /// <summary>
                        /// <para>The account ID of the delegated user.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20933221576142****</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The user type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>customer: Alibaba Cloud account.</description></item>
                        /// <item><description>sub: RAM user.</description></item>
                        /// <item><description>AssumedRoleUser: RAM role.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sub</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The credential configuration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Role: single role assumption.</description></item>
                /// <item><description>RoleChain: role chain assumption.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RoleChain</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable credential injection.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The number of CUs used by the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The list of datasets mounted to the instance.</para>
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<UpdateServerIdeInstanceRequestDatasets> Datasets { get; set; }
        public class UpdateServerIdeInstanceRequestDatasets : TeaModel {
            /// <summary>
            /// <para>The custom mount properties of the dataset. The content is passed as mount options.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fs.oss.download.thread.concurrency&quot;:&quot;10&quot;}</para>
            /// </summary>
            [NameInMap("ExtOptions")]
            [Validation(Required=false)]
            public string ExtOptions { get; set; }

            /// <summary>
            /// <para>The dataset identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-vsqjvs****rp5l206u</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The mount path of the dataset in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mnt/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>Specifies whether to mount the dataset in read-only mode.</para>
            /// </summary>
            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// <para>The storage service directory URI for direct mounting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://example-bucket/data/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

            /// <summary>
            /// <para>The dataset version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The image ID. You can call ListServerIdeImages to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System_serveride_notebook_20240822</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image URL. This parameter is required when you use a non-DataWorks official image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/example/serveride:latest</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The personal development environment instance ID. You can call ListServerIdeInstances to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>699573</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the personal development environment instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notebook_dev</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The VPC configuration used by the instance.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UpdateServerIdeInstanceRequestUserVpc UserVpc { get; set; }
        public class UpdateServerIdeInstanceRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>The list of port forwarding configurations.</para>
            /// </summary>
            [NameInMap("ForwardInfos")]
            [Validation(Required=false)]
            public List<UpdateServerIdeInstanceRequestUserVpcForwardInfos> ForwardInfos { get; set; }
            public class UpdateServerIdeInstanceRequestUserVpcForwardInfos : TeaModel {
                /// <summary>
                /// <para>The list of access types.</para>
                /// </summary>
                [NameInMap("AccessType")]
                [Validation(Required=false)]
                public List<string> AccessType { get; set; }

                /// <summary>
                /// <para>The name of the target container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dsw-notebook</para>
                /// </summary>
                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                /// <summary>
                /// <para>The instance ID of the public EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-bp1****</para>
                /// </summary>
                [NameInMap("EipAllocationId")]
                [Validation(Required=false)]
                public string EipAllocationId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the port forwarding configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The mapped public port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                /// <summary>
                /// <para>The target port in the instance container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("ForwardPort")]
                [Validation(Required=false)]
                public string ForwardPort { get; set; }

                /// <summary>
                /// <para>The name of the port forwarding configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ssh</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The NAT gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-bp1****</para>
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// <para>The public key used for SSH access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQ****</para>
                /// </summary>
                [NameInMap("SSHPublicKey")]
                [Validation(Required=false)]
                public string SSHPublicKey { get; set; }

            }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
