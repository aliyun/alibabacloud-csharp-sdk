// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetChangeSetRequest : TeaModel {
        /// <summary>
        /// The ID of the change set.
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// The region ID of the change set. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to show the template. Default value: false. Valid values:
        /// 
        /// *   true: shows the template.
        /// *   false: does not show the template.
        /// </summary>
        [NameInMap("ShowTemplate")]
        [Validation(Required=false)]
        public bool? ShowTemplate { get; set; }

    }

}
