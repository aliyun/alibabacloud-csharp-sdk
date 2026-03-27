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
            /// <summary>
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            [NameInMap("fieldValues")]
            [Validation(Required=false)]
            public List<string> FieldValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.0.1/10</para>
            /// </summary>
            [NameInMap("ipCIDR")]
            [Validation(Required=false)]
            public string IpCIDR { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hostIp</para>
            /// </summary>
            [NameInMap("ipFieldKey")]
            [Validation(Required=false)]
            public string IpFieldKey { get; set; }

        }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleLabels> Labels { get; set; }
        public class EntityDiscoverRuleLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfm2m7atreujs1</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleTags> Tags { get; set; }
        public class EntityDiscoverRuleTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}
