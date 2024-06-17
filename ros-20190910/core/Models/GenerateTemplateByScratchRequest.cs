// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplateByScratchRequest : TeaModel {
        /// <summary>
        /// The region ID of the new node.
        /// </summary>
        [NameInMap("ProvisionRegionId")]
        [Validation(Required=false)]
        public string ProvisionRegionId { get; set; }

        /// <summary>
        /// The region ID of the resource scenario.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource scenario.
        /// 
        /// For more information about how to query the IDs of resource scenarios, see [ListTemplateScratches](https://help.aliyun.com/document_detail/363050.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// The type of the template that Resource Orchestration Service (ROS) generates. ROS can generate templates of the ROS and Terraform types. Default value: ROS.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
