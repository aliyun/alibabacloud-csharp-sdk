// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CredentialConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AliyunEnvRoleKey")]
        [Validation(Required=false)]
        public string AliyunEnvRoleKey { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<CredentialConfigConfigs> Configs { get; set; }
        public class CredentialConfigConfigs : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<CredentialConfigConfigsRoles> Roles { get; set; }
            public class CredentialConfigConfigsRoles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123******</para>
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public string AssumeRoleFor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::123******:role/****</para>
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service</para>
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                [NameInMap("UserInfo")]
                [Validation(Required=false)]
                public CredentialConfigConfigsRolesUserInfo UserInfo { get; set; }
                public class CredentialConfigConfigsRolesUserInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LT********</para>
                    /// </summary>
                    [NameInMap("AccessKeyId")]
                    [Validation(Required=false)]
                    public string AccessKeyId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>456******</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("SecurityToken")]
                    [Validation(Required=false)]
                    public string SecurityToken { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>S</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Role</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

    }

}
