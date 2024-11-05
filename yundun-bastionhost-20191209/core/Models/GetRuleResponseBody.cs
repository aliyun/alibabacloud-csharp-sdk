// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned information about the authorization rule.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public GetRuleResponseBodyRule Rule { get; set; }
        public class GetRuleResponseBodyRule : TeaModel {
            /// <summary>
            /// <para>The remarks of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The databases on which permissions are granted by using the authorization rule.</para>
            /// </summary>
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleDatabases> Databases { get; set; }
            public class GetRuleResponseBodyRuleDatabases : TeaModel {
                /// <summary>
                /// <para>The database accounts on which permissions are granted by using the authorization rule.</para>
                /// </summary>
                [NameInMap("DatabaseAccounts")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyRuleDatabasesDatabaseAccounts> DatabaseAccounts { get; set; }
                public class GetRuleResponseBodyRuleDatabasesDatabaseAccounts : TeaModel {
                    /// <summary>
                    /// <para>The ID of the database account that the policy authorizes users to manage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("DatabaseAccountId")]
                    [Validation(Required=false)]
                    public string DatabaseAccountId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the database that the policy authorizes users to manage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

            }

            /// <summary>
            /// <para>The end time of the validity period of the authorization rule. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698720972</para>
            /// </summary>
            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public string EffectiveEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the authorization rule. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687140883</para>
            /// </summary>
            [NameInMap("EffectiveStartTime")]
            [Validation(Required=false)]
            public string EffectiveStartTime { get; set; }

            /// <summary>
            /// <para>The asset groups on which permissions are granted by using the authorization rule.</para>
            /// </summary>
            [NameInMap("HostGroups")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleHostGroups> HostGroups { get; set; }
            public class GetRuleResponseBodyRuleHostGroups : TeaModel {
                /// <summary>
                /// <para>The asset accounts on which permissions are granted by using the authorization rule.</para>
                /// </summary>
                [NameInMap("HostAccountNames")]
                [Validation(Required=false)]
                public List<string> HostAccountNames { get; set; }

                /// <summary>
                /// <para>The ID of the asset group that the policy authorizes users to manage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("HostGroupId")]
                [Validation(Required=false)]
                public string HostGroupId { get; set; }

            }

            /// <summary>
            /// <para>The information about the hosts that the policy authorizes users to manage.</para>
            /// </summary>
            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleHosts> Hosts { get; set; }
            public class GetRuleResponseBodyRuleHosts : TeaModel {
                /// <summary>
                /// <para>The host accounts that the policy authorizes users to manage.</para>
                /// </summary>
                [NameInMap("HostAccounts")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyRuleHostsHostAccounts> HostAccounts { get; set; }
                public class GetRuleResponseBodyRuleHostsHostAccounts : TeaModel {
                    /// <summary>
                    /// <para>The ID of the host account that the policy authorizes users to manage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("HostAccountId")]
                    [Validation(Required=false)]
                    public string HostAccountId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the host that the policy authorizes users to manage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>52</para>
                /// </summary>
                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The authorized user groups.</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleUserGroups> UserGroups { get; set; }
            public class GetRuleResponseBodyRuleUserGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the authorized user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

            }

            /// <summary>
            /// <para>The authorized users.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleUsers> Users { get; set; }
            public class GetRuleResponseBodyRuleUsers : TeaModel {
                /// <summary>
                /// <para>The ID of the authorized user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
