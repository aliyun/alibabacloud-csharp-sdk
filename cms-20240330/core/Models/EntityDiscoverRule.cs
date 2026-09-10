// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EntityDiscoverRule : TeaModel {
        /// <summary>
        /// <para>The collection of annotation matching rules.</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleAnnotations> Annotations { get; set; }
        public class EntityDiscoverRuleAnnotations : TeaModel {
            /// <summary>
            /// <para>The operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The key of the annotation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The collection of annotation values.</para>
            /// </summary>
            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

        /// <summary>
        /// <para>The collection of entity types.</para>
        /// </summary>
        [NameInMap("entityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>The property matching rules.</para>
        /// </summary>
        [NameInMap("fieldRules")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleFieldRules> FieldRules { get; set; }
        public class EntityDiscoverRuleFieldRules : TeaModel {
            /// <summary>
            /// <para>The key of the property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            /// <summary>
            /// <para>The collection of property values.</para>
            /// </summary>
            [NameInMap("fieldValues")]
            [Validation(Required=false)]
            public List<string> FieldValues { get; set; }

            /// <summary>
            /// <para>The operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

        }

        /// <summary>
        /// <para>The collection of instance IDs.</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The collection of IP matching rules.</para>
        /// </summary>
        [NameInMap("ipMatchRule")]
        [Validation(Required=false)]
        public EntityDiscoverRuleIpMatchRule IpMatchRule { get; set; }
        public class EntityDiscoverRuleIpMatchRule : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("ipCIDR")]
            [Validation(Required=false)]
            public string IpCIDR { get; set; }

            /// <summary>
            /// <para>The property key of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs_ip</para>
            /// </summary>
            [NameInMap("ipFieldKey")]
            [Validation(Required=false)]
            public string IpFieldKey { get; set; }

        }

        /// <summary>
        /// <para>The collection of label matching rules.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleLabels> Labels { get; set; }
        public class EntityDiscoverRuleLabels : TeaModel {
            /// <summary>
            /// <para>The operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The key of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The collection of label values.</para>
            /// </summary>
            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

        /// <summary>
        /// <para>The collection of region IDs.</para>
        /// </summary>
        [NameInMap("regionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2m7atreujs1</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag-based service discovery settings.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleTags> Tags { get; set; }
        public class EntityDiscoverRuleTags : TeaModel {
            /// <summary>
            /// <para>The operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The collection of tag values.</para>
            /// </summary>
            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}
