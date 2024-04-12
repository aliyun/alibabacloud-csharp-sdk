// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetPolicyAssetScopeResponseBody : TeaModel {
        [NameInMap("AssetScope")]
        [Validation(Required=false)]
        public GetPolicyAssetScopeResponseBodyAssetScope AssetScope { get; set; }
        public class GetPolicyAssetScopeResponseBodyAssetScope : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<GetPolicyAssetScopeResponseBodyAssetScopeDatabases> Databases { get; set; }
            public class GetPolicyAssetScopeResponseBodyAssetScopeDatabases : TeaModel {
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
            public List<GetPolicyAssetScopeResponseBodyAssetScopeHostGroups> HostGroups { get; set; }
            public class GetPolicyAssetScopeResponseBodyAssetScopeHostGroups : TeaModel {
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
            public List<GetPolicyAssetScopeResponseBodyAssetScopeHosts> Hosts { get; set; }
            public class GetPolicyAssetScopeResponseBodyAssetScopeHosts : TeaModel {
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

            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
