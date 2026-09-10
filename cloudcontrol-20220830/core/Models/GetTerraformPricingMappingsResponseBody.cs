// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetTerraformPricingMappingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The mapping content version, which is the timestamp of the most recent data change. Consumers can use this value for caching and auditing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786000000000</para>
        /// </summary>
        [NameInMap("mappingVersion")]
        [Validation(Required=false)]
        public string MappingVersion { get; set; }

        /// <summary>
        /// <para>The list of matched mappings. Each item contains a resourceType and pricingTargets, which include pricing targets and parameter extraction rules. The rules reference Terraform plan resource properties by using $after/$before.</para>
        /// </summary>
        [NameInMap("mappings")]
        [Validation(Required=false)]
        public List<GetTerraformPricingMappingsResponseBodyMappings> Mappings { get; set; }
        public class GetTerraformPricingMappingsResponseBodyMappings : TeaModel {
            /// <summary>
            /// <para>The list of pricing targets. Each item contains actions (create/update), popCode/popVersion/apiName, pricingUnit, params (parameter extraction rules: from=$after.xxx / const / default / expand), and when/whenChanged conditions.</para>
            /// </summary>
            [NameInMap("pricingTargets")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> PricingTargets { get; set; }

            /// <summary>
            /// <para>The Terraform resource type, such as alicloud_instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_instance</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The resource types in the request that do not have registered mappings. Consumers must treat these as unknown cost. Do not assume they are free.</para>
        /// </summary>
        [NameInMap("missingResourceTypes")]
        [Validation(Required=false)]
        public List<string> MissingResourceTypes { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AF0AD89-ED4F-5E9E-8B7B-9A3B27CE9E1B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The schema version of the mapping catalog. The current version is 1.0. Consumers use this value to determine compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>The resource types that are confirmed to not support pricing, such as free resources or resources without a pricing interface. These are different from missing resource types.</para>
        /// </summary>
        [NameInMap("unsupportedResourceTypes")]
        [Validation(Required=false)]
        public List<string> UnsupportedResourceTypes { get; set; }

    }

}
