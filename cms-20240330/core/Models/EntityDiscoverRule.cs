// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EntityDiscoverRule : TeaModel {
        /// <summary>
        /// <para>注解匹配集合。</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleAnnotations> Annotations { get; set; }
        public class EntityDiscoverRuleAnnotations : TeaModel {
            /// <summary>
            /// <para>操作。</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>注解的Key。</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>注解的值集合。</para>
            /// </summary>
            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

        /// <summary>
        /// <para>实体类型集合。</para>
        /// </summary>
        [NameInMap("entityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>属性匹配规则。</para>
        /// </summary>
        [NameInMap("fieldRules")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleFieldRules> FieldRules { get; set; }
        public class EntityDiscoverRuleFieldRules : TeaModel {
            /// <summary>
            /// <para>属性的Key。</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            /// <summary>
            /// <para>属性的值集合。</para>
            /// </summary>
            [NameInMap("fieldValues")]
            [Validation(Required=false)]
            public List<string> FieldValues { get; set; }

            /// <summary>
            /// <para>操作。</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

        }

        /// <summary>
        /// <para>实例ID集合。</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>IP匹配规则集合。</para>
        /// </summary>
        [NameInMap("ipMatchRule")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleIpMatchRule> IpMatchRule { get; set; }
        public class EntityDiscoverRuleIpMatchRule : TeaModel {
            /// <summary>
            /// <para>IP的CIDR。</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1/10</para>
            /// </summary>
            [NameInMap("ipCIDR")]
            [Validation(Required=false)]
            public string IpCIDR { get; set; }

            /// <summary>
            /// <para>IP字段的Key。</para>
            /// 
            /// <b>Example:</b>
            /// <para>hostIp</para>
            /// </summary>
            [NameInMap("ipFieldKey")]
            [Validation(Required=false)]
            public string IpFieldKey { get; set; }

        }

        /// <summary>
        /// <para>标签匹配集合。</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleLabels> Labels { get; set; }
        public class EntityDiscoverRuleLabels : TeaModel {
            /// <summary>
            /// <para>操作。</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>标签的Key。</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>标签的值集合。</para>
            /// </summary>
            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

        /// <summary>
        /// <para>地域ID集合。</para>
        /// </summary>
        [NameInMap("regionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>资源组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2m7atreujs1</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>通过Tag进行服务发现。</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<EntityDiscoverRuleTags> Tags { get; set; }
        public class EntityDiscoverRuleTags : TeaModel {
            /// <summary>
            /// <para>操作。</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>Tag的Key。</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>Tag的值集合。</para>
            /// </summary>
            [NameInMap("tagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}
