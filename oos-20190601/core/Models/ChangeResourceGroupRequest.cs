// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which the cloud resource is to be moved. You can use resource groups to manage resources owned by your Alibaba Cloud account. Resource groups simplify the resource and permission management of your Alibaba Cloud account. For more information, see [What is Resource Management?](~~94475~~)
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the cloud resource that you want to move to another resource group.
        /// 
        /// *   If the ResourceType parameter is set to template, set the ResourceId parameter to the name of the template.
        /// *   If the ResourceType parameter is set to parameter, set the ResourceId parameter to the name of the parameter.
        /// *   If the ResourceType parameter is set to secretparameter, set the ResourceId parameter to the name of the encryption parameter.
        /// *   If the ResourceType parameter is set to stateconfiguration, set the ResourceId parameter to the ID of the desired-state configuration.
        /// *   If the ResourceType parameter is set to application, set the ResourceId parameter to the name of the application.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the cloud resource. Valid values:
        /// 
        /// *   template: template
        /// *   parameter: parameter
        /// *   secretparameter: encryption parameter
        /// *   stateconfiguration: desired-state configuration
        /// *   application: application
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
