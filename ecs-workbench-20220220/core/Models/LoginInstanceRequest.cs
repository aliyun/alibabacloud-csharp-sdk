/**
 *
 */
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
            [NameInMap("AuthenticationType")]
            [Validation(Required=false)]
            public string AuthenticationType { get; set; }

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

            [NameInMap("DurationSeconds")]
            [Validation(Required=false)]
            public long? DurationSeconds { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("LoginByInstanceCredential")]
            [Validation(Required=false)]
            public bool? LoginByInstanceCredential { get; set; }

            [NameInMap("LoginByInstanceShortcut")]
            [Validation(Required=false)]
            public bool? LoginByInstanceShortcut { get; set; }

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
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    [NameInMap("ContainerName")]
                    [Validation(Required=false)]
                    public string ContainerName { get; set; }

                    [NameInMap("Deployment")]
                    [Validation(Required=false)]
                    public string Deployment { get; set; }

                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Headers { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

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

                [NameInMap("NotificationEventTypes")]
                [Validation(Required=false)]
                public string NotificationEventTypes { get; set; }

                [NameInMap("NotificationRecipientUrl")]
                [Validation(Required=false)]
                public string NotificationRecipientUrl { get; set; }

                [NameInMap("NotificationRetryIntervalSeconds")]
                [Validation(Required=false)]
                public int? NotificationRetryIntervalSeconds { get; set; }

                [NameInMap("NotificationRetryLimit")]
                [Validation(Required=false)]
                public int? NotificationRetryLimit { get; set; }

                [NameInMap("OperationDisableSeconds")]
                [Validation(Required=false)]
                public int? OperationDisableSeconds { get; set; }

                [NameInMap("SessionControl")]
                [Validation(Required=false)]
                public string SessionControl { get; set; }

                [NameInMap("VideoFreezeSeconds")]
                [Validation(Required=false)]
                public int? VideoFreezeSeconds { get; set; }

            }

            [NameInMap("PassPhrase")]
            [Validation(Required=false)]
            public string PassPhrase { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ShortcutToken")]
            [Validation(Required=false)]
            public string ShortcutToken { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("PartnerInfo")]
        [Validation(Required=false)]
        public LoginInstanceRequestPartnerInfo PartnerInfo { get; set; }
        public class LoginInstanceRequestPartnerInfo : TeaModel {
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public string PartnerId { get; set; }

            [NameInMap("PartnerName")]
            [Validation(Required=false)]
            public string PartnerName { get; set; }

        }

        [NameInMap("UserAccount")]
        [Validation(Required=false)]
        public LoginInstanceRequestUserAccount UserAccount { get; set; }
        public class LoginInstanceRequestUserAccount : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            [NameInMap("AccountPlatform")]
            [Validation(Required=false)]
            public string AccountPlatform { get; set; }

            [NameInMap("AccountStructure")]
            [Validation(Required=false)]
            public string AccountStructure { get; set; }

            [NameInMap("DurationSeconds")]
            [Validation(Required=false)]
            public long? DurationSeconds { get; set; }

            [NameInMap("EmpId")]
            [Validation(Required=false)]
            public string EmpId { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public LoginInstanceRequestUserAccountOptions Options { get; set; }
            public class LoginInstanceRequestUserAccountOptions : TeaModel {
                [NameInMap("LoginLimit")]
                [Validation(Required=false)]
                public long? LoginLimit { get; set; }

            }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

        }

    }

}
