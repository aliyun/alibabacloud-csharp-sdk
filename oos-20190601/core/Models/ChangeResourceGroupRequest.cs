// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which the cloud resource is to be moved. You can use resource groups to manage resources owned by your Alibaba Cloud account. Resource groups simplify the resource and permission management of your Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/94475.html">What is Resource Management?</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3peow3k****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

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
        /// <para>The ID of the cloud resource that you want to move to another resource group.</para>
        /// <list type="bullet">
        /// <item><description>If the ResourceType parameter is set to template, set the ResourceId parameter to the name of the template.</description></item>
        /// <item><description>If the ResourceType parameter is set to parameter, set the ResourceId parameter to the name of the parameter.</description></item>
        /// <item><description>If the ResourceType parameter is set to secretparameter, set the ResourceId parameter to the name of the encryption parameter.</description></item>
        /// <item><description>If the ResourceType parameter is set to stateconfiguration, set the ResourceId parameter to the ID of the desired-state configuration.</description></item>
        /// <item><description>If the ResourceType parameter is set to application, set the ResourceId parameter to the name of the application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TemplateName</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the cloud resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>template: template</description></item>
        /// <item><description>parameter: parameter</description></item>
        /// <item><description>secretparameter: encryption parameter</description></item>
        /// <item><description>stateconfiguration: desired-state configuration</description></item>
        /// <item><description>application: application</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
