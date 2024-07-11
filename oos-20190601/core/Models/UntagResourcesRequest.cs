// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags. This parameter takes effect only if TagKeys is left empty. Valid values: true and false. Default value: false. TagKeys is required if this parameter is set to false.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the resources for which you want to modify the resource group. The number of resource IDs is 1 to 50.
        /// 
        /// *   If you set ResourceType to template, specify ResourceIds in the ["TemplateName1","TemplateName2"] format.
        /// *   If you set ResourceType to parameter, specify ResourceIds in the ["Name1","Name2"] format.
        /// *   If you set ResourceType to secretparameter, specify ResourceIds in the ["Name1","Name2"] format.
        /// *   If you set ResourceType to stateconfiguration, specify ResourceIds in the ["StateConfigurationId 1","StateConfigurationId 2"] format.
        /// *   If you set ResourceType to application, specify ResourceIds in the ["Name1","Name2"] format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceIds { get; set; }

        /// <summary>
        /// The type of the resource for which you want to modify the resource group. Valid values:
        /// 
        /// *   template: template.
        /// *   parameter: parameter.
        /// *   secretparameter: encryption parameter.
        /// *   stateconfiguration: desired-state configuration.
        /// *   application: application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag keys. The number of keys ranges from 1 to 20.
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public Dictionary<string, object> TagKeys { get; set; }

    }

}
