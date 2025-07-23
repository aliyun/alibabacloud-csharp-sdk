// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EntityDiscoverRule : TeaModel {
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleAnnotations> Annotations { get; set; }
        public class EntityDiscoverRuleAnnotations : TeaModel {
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

        [NameInMap("entityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        [NameInMap("fieldRules")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleFieldRules> FieldRules { get; set; }
        public class EntityDiscoverRuleFieldRules : TeaModel {
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            [NameInMap("fieldValues")]
            [Validation(Required=false)]
            public List<string> FieldValues { get; set; }

            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

        }

        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("ipMatchRule")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleIpMatchRule> IpMatchRule { get; set; }
        public class EntityDiscoverRuleIpMatchRule : TeaModel {
            [NameInMap("ipCIDR")]
            [Validation(Required=false)]
            public string IpCIDR { get; set; }

            [NameInMap("ipFieldKey")]
            [Validation(Required=false)]
            public string IpFieldKey { get; set; }

        }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleLabels> Labels { get; set; }
        public class EntityDiscoverRuleLabels : TeaModel {
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

        [NameInMap("regionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleTags> Tags { get; set; }
        public class EntityDiscoverRuleTags : TeaModel {
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}
