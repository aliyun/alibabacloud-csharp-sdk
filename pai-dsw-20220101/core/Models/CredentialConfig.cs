/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CredentialConfig : TeaModel {
        [NameInMap("AliyunEnvRoleKey")]
        [Validation(Required=false)]
        public string AliyunEnvRoleKey { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<CredentialConfigConfigs> Configs { get; set; }
        public class CredentialConfigConfigs : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<CredentialConfigConfigsRoles> Roles { get; set; }
            public class CredentialConfigConfigsRoles : TeaModel {
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public string AssumeRoleFor { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                [NameInMap("UserInfo")]
                [Validation(Required=false)]
                public CredentialConfigConfigsRolesUserInfo UserInfo { get; set; }
                public class CredentialConfigConfigsRolesUserInfo : TeaModel {
                    [NameInMap("AccessKeyId")]
                    [Validation(Required=false)]
                    public string AccessKeyId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("SecurityToken")]
                    [Validation(Required=false)]
                    public string SecurityToken { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

    }

}
