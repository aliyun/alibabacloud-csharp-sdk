// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCollectionPolicyResponseBody : TeaModel {
        [NameInMap("collectionPolicy")]
        [Validation(Required=false)]
        public GetCollectionPolicyResponseBodyCollectionPolicy CollectionPolicy { get; set; }
        public class GetCollectionPolicyResponseBodyCollectionPolicy : TeaModel {
            [NameInMap("centralizeConfig")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyCentralizeConfig CentralizeConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyCentralizeConfig : TeaModel {
                [NameInMap("destLogstore")]
                [Validation(Required=false)]
                public string DestLogstore { get; set; }

                [NameInMap("destProject")]
                [Validation(Required=false)]
                public string DestProject { get; set; }

                [NameInMap("destRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("destTTL")]
                [Validation(Required=false)]
                public int? DestTTL { get; set; }

            }

            [NameInMap("centralizeEnabled")]
            [Validation(Required=false)]
            public bool? CentralizeEnabled { get; set; }

            [NameInMap("dataCode")]
            [Validation(Required=false)]
            public string DataCode { get; set; }

            [NameInMap("dataConfig")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyDataConfig DataConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyDataConfig : TeaModel {
                [NameInMap("dataProject")]
                [Validation(Required=false)]
                public string DataProject { get; set; }

                [NameInMap("dataRegion")]
                [Validation(Required=false)]
                public string DataRegion { get; set; }

            }

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("internalPolicy")]
            [Validation(Required=false)]
            public bool? InternalPolicy { get; set; }

            [NameInMap("policyConfig")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyPolicyConfig PolicyConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyPolicyConfig : TeaModel {
                [NameInMap("instanceIds")]
                [Validation(Required=false)]
                public List<string> InstanceIds { get; set; }

                [NameInMap("regions")]
                [Validation(Required=false)]
                public List<string> Regions { get; set; }

                [NameInMap("resourceMode")]
                [Validation(Required=false)]
                public string ResourceMode { get; set; }

                [NameInMap("resourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

            }

            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("policyUid")]
            [Validation(Required=false)]
            public string PolicyUid { get; set; }

            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("resourceDirectory")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyResourceDirectory ResourceDirectory { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyResourceDirectory : TeaModel {
                [NameInMap("accountGroupType")]
                [Validation(Required=false)]
                public string AccountGroupType { get; set; }

                [NameInMap("members")]
                [Validation(Required=false)]
                public List<string> Members { get; set; }

            }

        }

    }

}
