// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyAssetScopeRequest : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestDatabases> Databases { get; set; }
        public class SetPolicyAssetScopeRequestDatabases : TeaModel {
            [NameInMap("AccountScopeType")]
            [Validation(Required=false)]
            public string AccountScopeType { get; set; }

            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestHostGroups> HostGroups { get; set; }
        public class SetPolicyAssetScopeRequestHostGroups : TeaModel {
            [NameInMap("AccountNames")]
            [Validation(Required=false)]
            public List<string> AccountNames { get; set; }

            [NameInMap("AccountScopeType")]
            [Validation(Required=false)]
            public string AccountScopeType { get; set; }

            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

        }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestHosts> Hosts { get; set; }
        public class SetPolicyAssetScopeRequestHosts : TeaModel {
            [NameInMap("AccountScopeType")]
            [Validation(Required=false)]
            public string AccountScopeType { get; set; }

            [NameInMap("HostAccountIds")]
            [Validation(Required=false)]
            public List<string> HostAccountIds { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
