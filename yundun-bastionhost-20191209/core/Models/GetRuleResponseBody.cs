// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rule")]
        [Validation(Required=false)]
        public GetRuleResponseBodyRule Rule { get; set; }
        public class GetRuleResponseBodyRule : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleDatabases> Databases { get; set; }
            public class GetRuleResponseBodyRuleDatabases : TeaModel {
                [NameInMap("DatabaseAccounts")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyRuleDatabasesDatabaseAccounts> DatabaseAccounts { get; set; }
                public class GetRuleResponseBodyRuleDatabasesDatabaseAccounts : TeaModel {
                    [NameInMap("DatabaseAccountId")]
                    [Validation(Required=false)]
                    public string DatabaseAccountId { get; set; }

                }

                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

            }

            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public string EffectiveEndTime { get; set; }

            [NameInMap("EffectiveStartTime")]
            [Validation(Required=false)]
            public string EffectiveStartTime { get; set; }

            [NameInMap("HostGroups")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleHostGroups> HostGroups { get; set; }
            public class GetRuleResponseBodyRuleHostGroups : TeaModel {
                [NameInMap("HostAccountNames")]
                [Validation(Required=false)]
                public List<string> HostAccountNames { get; set; }

                [NameInMap("HostGroupId")]
                [Validation(Required=false)]
                public string HostGroupId { get; set; }

            }

            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleHosts> Hosts { get; set; }
            public class GetRuleResponseBodyRuleHosts : TeaModel {
                [NameInMap("HostAccounts")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyRuleHostsHostAccounts> HostAccounts { get; set; }
                public class GetRuleResponseBodyRuleHostsHostAccounts : TeaModel {
                    [NameInMap("HostAccountId")]
                    [Validation(Required=false)]
                    public string HostAccountId { get; set; }

                }

                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }

            }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleUserGroups> UserGroups { get; set; }
            public class GetRuleResponseBodyRuleUserGroups : TeaModel {
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

            }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyRuleUsers> Users { get; set; }
            public class GetRuleResponseBodyRuleUsers : TeaModel {
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
