// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content of the template. The content must be in the JSON or YAML format, and its maximum size is 64 KB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;FormatVersion&quot;: &quot;OOS-2019-06-01&quot;, &quot;Description&quot;: { &quot;en&quot;: &quot;Bulky starts the ECS instances&quot;, &quot;name-en&quot;: &quot;Bulky Start Instances&quot;, }, &quot;Parameters&quot;: { &quot;regionId&quot;: { &quot;Type&quot;: &quot;String&quot;, &quot;Label&quot;: { &quot;en&quot;: &quot;RegionId&quot;, }, &quot;AssociationProperty&quot;: &quot;RegionId&quot;, &quot;Default&quot;: &quot;{{ ACS::RegionId }}&quot; }, &quot;targets&quot;: { &quot;Type&quot;: &quot;Json&quot;, &quot;Label&quot;: { &quot;en&quot;: &quot;TargetInstance&quot;, }, &quot;AssociationProperty&quot;: &quot;Targets&quot;, &quot;AssociationPropertyMetadata&quot;: { &quot;ResourceType&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;RegionId&quot;: &quot;regionId&quot; } }, &quot;rateControl&quot;: { &quot;Label&quot;: { &quot;en&quot;: &quot;RateControl&quot;, }, &quot;Type&quot;: &quot;Json&quot;, &quot;AssociationProperty&quot;: &quot;RateControl&quot;, &quot;Default&quot;: { &quot;Mode&quot;: &quot;Concurrency&quot;, &quot;MaxErrors&quot;: 0, &quot;Concurrency&quot;: 10 } }, &quot;OOSAssumeRole&quot;: { &quot;Label&quot;: { &quot;en&quot;: &quot;OOSAssumeRole&quot;, }, &quot;Type&quot;: &quot;String&quot;, &quot;Default&quot;: &quot;OOSServiceRole&quot; } }, &quot;RamRole&quot;: &quot;{{ OOSAssumeRole }}&quot;, &quot;Tasks&quot;: [ { &quot;Name&quot;: &quot;getInstance&quot;, &quot;Description&quot;: { &quot;en&quot;: &quot;Views the ECS instances&quot;, }, &quot;Action&quot;: &quot;ACS::SelectTargets&quot;, &quot;Properties&quot;: { &quot;ResourceType&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;RegionId&quot;: &quot;{{ regionId }}&quot;, &quot;Filters&quot;: [ &quot;{{ targets }}&quot; ] }, &quot;Outputs&quot;: { &quot;instanceIds&quot;: { &quot;Type&quot;: &quot;List&quot;, &quot;ValueSelector&quot;: &quot;Instances.Instance[].InstanceId&quot; } } }, { &quot;Name&quot;: &quot;startInstance&quot;, &quot;Action&quot;: &quot;ACS::ECS::StartInstance&quot;, &quot;Description&quot;: { &quot;en&quot;: &quot;Starts the ECS instances&quot;, }, &quot;Properties&quot;: { &quot;regionId&quot;: &quot;{{ regionId }}&quot;, &quot;instanceId&quot;: &quot;{{ ACS::TaskLoopItem }}&quot; }, &quot;Loop&quot;: { &quot;RateControl&quot;: &quot;{{ rateControl }}&quot;, &quot;Items&quot;: &quot;{{ getInstance.instanceIds }}&quot; } } ], &quot;Outputs&quot;: { &quot;instanceIds&quot;: { &quot;Type&quot;: &quot;List&quot;, &quot;Value&quot;: &quot;{{ getInstance.instanceIds }}&quot; } } }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag keys and values. The number of key-value pairs ranges from 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;k2&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The name of the template. The name can be up to 200 characters in length and can contain letters, digits, hyphens (-), and underscores (_). The name cannot start with ALIYUN, ACS, ALIBABA, or ALICLOUD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The name of the template version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
