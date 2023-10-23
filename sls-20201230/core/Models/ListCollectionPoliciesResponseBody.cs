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
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataAttribute Attribute { get; set; }
            public class ListCollectionPoliciesResponseBodyDataAttribute : TeaModel {
                [NameInMap("app")]
                [Validation(Required=false)]
                public string App { get; set; }

                [NameInMap("policyGroup")]
                [Validation(Required=false)]
                public string PolicyGroup { get; set; }

            }

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

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

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

            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
