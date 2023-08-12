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
        /// The region ID of the scenario.
        /// 
        /// You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the scenario.
        /// 
        /// For more information about how to query the IDs of scenarios, see [ListTemplateScratches](~~363050~~).
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
