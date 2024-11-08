// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content of the template. The content must be in the JSON or YAML format, and its maximum size is 64 KB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FormatVersion&quot;: &quot;OOS-2019-06-01&quot;, &quot;Description&quot;: &quot;Describe instances of given status&quot;, &quot;Parameters&quot;: {&quot;Status&quot;: {&quot;Type&quot;: &quot;String&quot;, &quot;Description&quot;: &quot;(Required) The status of the Ecs instance.&quot;}}, &quot;Tasks&quot;: [{&quot;Properties&quot;: {&quot;Parameters&quot;: {&quot;Status&quot;: &quot;{{ Status }}&quot;}, &quot;API&quot;: &quot;DescribeInstances&quot;, &quot;Service&quot;: &quot;Ecs&quot;}, &quot;Name&quot;: &quot;foo&quot;, &quot;Action&quot;: &quot;ACS::ExecuteApi&quot;}]}</para>
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
        /// <para>The tag keys and tag values. The number of key-value pairs ranges from 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The name of the template. The name can be 1 to 200 characters in length and can contain letters, digits, hyphens (-), and underscores (_). The name cannot start with ALIYUN, ACS, ALIBABA, or ALICLOUD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The name of the version of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
