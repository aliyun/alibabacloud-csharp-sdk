// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListCollectionPoliciesResponseBody : TeaModel {
        [NameInMap("currentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListCollectionPoliciesResponseBodyData> Data { get; set; }
        public class ListCollectionPoliciesResponseBodyData : TeaModel {
            [NameInMap("centralizeConfig")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataCentralizeConfig CentralizeConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataCentralizeConfig : TeaModel {
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
            public ListCollectionPoliciesResponseBodyDataDataConfig DataConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataDataConfig : TeaModel {
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
            public ListCollectionPoliciesResponseBodyDataPolicyConfig PolicyConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataPolicyConfig : TeaModel {
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
            public ListCollectionPoliciesResponseBodyDataResourceDirectory ResourceDirectory { get; set; }
            public class ListCollectionPoliciesResponseBodyDataResourceDirectory : TeaModel {
                [NameInMap("accountGroupType")]
                [Validation(Required=false)]
                public string AccountGroupType { get; set; }

                [NameInMap("members")]
                [Validation(Required=false)]
                public List<string> Members { get; set; }

            }

        }

        [NameInMap("statistics")]
        [Validation(Required=false)]
        public List<ListCollectionPoliciesResponseBodyStatistics> Statistics { get; set; }
        public class ListCollectionPoliciesResponseBodyStatistics : TeaModel {
            [NameInMap("policySourceList")]
            [Validation(Required=false)]
            public List<ListCollectionPoliciesResponseBodyStatisticsPolicySourceList> PolicySourceList { get; set; }
            public class ListCollectionPoliciesResponseBodyStatisticsPolicySourceList : TeaModel {
                [NameInMap("policyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                [NameInMap("policyUid")]
                [Validation(Required=false)]
                public string PolicyUid { get; set; }

            }

            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
