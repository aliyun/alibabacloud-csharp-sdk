// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UntagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags. This parameter takes effect only if TagKeys is left empty. Valid values: true and false. Default value: false. TagKeys is required if this parameter is set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the resources for which you want to modify the resource group. The number of resource IDs is 1 to 50.</para>
        /// <list type="bullet">
        /// <item><description>If you set ResourceType to template, specify ResourceIds in the [&quot;TemplateName1&quot;,&quot;TemplateName2&quot;] format.</description></item>
        /// <item><description>If you set ResourceType to parameter, specify ResourceIds in the [&quot;Name1&quot;,&quot;Name2&quot;] format.</description></item>
        /// <item><description>If you set ResourceType to secretparameter, specify ResourceIds in the [&quot;Name1&quot;,&quot;Name2&quot;] format.</description></item>
        /// <item><description>If you set ResourceType to stateconfiguration, specify ResourceIds in the [&quot;StateConfigurationId 1&quot;,&quot;StateConfigurationId 2&quot;] format.</description></item>
        /// <item><description>If you set ResourceType to application, specify ResourceIds in the [&quot;Name1&quot;,&quot;Name2&quot;] format.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;templateName1&quot;,&quot;templateName2&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the resource for which you want to modify the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>template: template.</description></item>
        /// <item><description>parameter: parameter.</description></item>
        /// <item><description>secretparameter: encryption parameter.</description></item>
        /// <item><description>stateconfiguration: desired-state configuration.</description></item>
        /// <item><description>application: application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag keys. The number of keys ranges from 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;k1&quot;,&quot;k2&quot;]</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeysShrink { get; set; }

    }

}
