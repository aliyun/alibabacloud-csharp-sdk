// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class LoginInstanceRequest : TeaModel {
        [NameInMap("InstanceLoginInfo")]
        [Validation(Required=false)]
        public LoginInstanceRequestInstanceLoginInfo InstanceLoginInfo { get; set; }
        public class LoginInstanceRequestInstanceLoginInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>password/certificate</para>
            /// </summary>
            [NameInMap("AuthenticationType")]
            [Validation(Required=false)]
            public string AuthenticationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>----begin----
            /// ----end----</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            [NameInMap("CredentialToken")]
            [Validation(Required=false)]
            public string CredentialToken { get; set; }

            [NameInMap("DockerContainerName")]
            [Validation(Required=false)]
            public string DockerContainerName { get; set; }

            [NameInMap("DockerExec")]
            [Validation(Required=false)]
            public string DockerExec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DurationSeconds")]
            [Validation(Required=false)]
            public long? DurationSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-11-30 00:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-123</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs/eci/ack</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("LoginByInstanceCredential")]
            [Validation(Required=false)]
            public bool? LoginByInstanceCredential { get; set; }

            [NameInMap("LoginByInstanceShortcut")]
            [Validation(Required=false)]
            public bool? LoginByInstanceShortcut { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc/classic</para>
            /// </summary>
            [NameInMap("NetworkAccessMode")]
            [Validation(Required=false)]
            public string NetworkAccessMode { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public LoginInstanceRequestInstanceLoginInfoOptions Options { get; set; }
            public class LoginInstanceRequestInstanceLoginInfoOptions : TeaModel {
                [NameInMap("AudioMuteSeconds")]
                [Validation(Required=false)]
                public int? AudioMuteSeconds { get; set; }

                [NameInMap("ContainerInfo")]
                [Validation(Required=false)]
                public LoginInstanceRequestInstanceLoginInfoOptionsContainerInfo ContainerInfo { get; set; }
                public class LoginInstanceRequestInstanceLoginInfoOptionsContainerInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abcdef</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("ContainerName")]
                    [Validation(Required=false)]
                    public string ContainerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("Deployment")]
                    [Validation(Required=false)]
                    public string Deployment { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;abc&quot;:&quot;def&quot;}</para>
                    /// </summary>
                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Headers { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("PodName")]
                    [Validation(Required=false)]
                    public string PodName { get; set; }

                }

                [NameInMap("FixedHeight")]
                [Validation(Required=false)]
                public int? FixedHeight { get; set; }

                [NameInMap("FixedWidth")]
                [Validation(Required=false)]
                public int? FixedWidth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("NotificationEventTypes")]
                [Validation(Required=false)]
                public string NotificationEventTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("NotificationRecipientUrl")]
                [Validation(Required=false)]
                public string NotificationRecipientUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("NotificationRetryIntervalSeconds")]
                [Validation(Required=false)]
                public int? NotificationRetryIntervalSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NotificationRetryLimit")]
                [Validation(Required=false)]
                public int? NotificationRetryLimit { get; set; }

                [NameInMap("OperationDisableSeconds")]
                [Validation(Required=false)]
                public int? OperationDisableSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("SessionControl")]
                [Validation(Required=false)]
                public string SessionControl { get; set; }

                [NameInMap("VideoFreezeSeconds")]
                [Validation(Required=false)]
                public int? VideoFreezeSeconds { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("PassPhrase")]
            [Validation(Required=false)]
            public string PassPhrase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22/3389</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ssh/rdp/ack</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou/cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ShortcutToken")]
            [Validation(Required=false)]
            public string ShortcutToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root/Administrator</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-abc</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("PartnerInfo")]
        [Validation(Required=false)]
        public LoginInstanceRequestPartnerInfo PartnerInfo { get; set; }
        public class LoginInstanceRequestPartnerInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public string PartnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("PartnerName")]
            [Validation(Required=false)]
            public string PartnerName { get; set; }

        }

        [NameInMap("UserAccount")]
        [Validation(Required=false)]
        public LoginInstanceRequestUserAccount UserAccount { get; set; }
        public class LoginInstanceRequestUserAccount : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aas</para>
            /// </summary>
            [NameInMap("AccountPlatform")]
            [Validation(Required=false)]
            public string AccountPlatform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2/3/4</para>
            /// </summary>
            [NameInMap("AccountStructure")]
            [Validation(Required=false)]
            public string AccountStructure { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DurationSeconds")]
            [Validation(Required=false)]
            public long? DurationSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123abc</para>
            /// </summary>
            [NameInMap("EmpId")]
            [Validation(Required=false)]
            public string EmpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-11-30 00:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public LoginInstanceRequestUserAccountOptions Options { get; set; }
            public class LoginInstanceRequestUserAccountOptions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("LoginLimit")]
                [Validation(Required=false)]
                public long? LoginLimit { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

        }

    }

}
