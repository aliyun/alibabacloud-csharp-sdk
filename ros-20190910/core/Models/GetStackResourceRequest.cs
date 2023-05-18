// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResourceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the resource properties. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of resource property N that you want to query.
        /// 
        /// >  Maximum value of N: 20.
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// The logical ID of the resource defined in the template.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The status of the resource. Valid values:
        /// 
        /// *   CREATE_COMPLETE
        /// *   CREATE_FAILED
        /// *   CREATE_IN_PROGRESS
        /// *   UPDATE_IN_PROGRESS
        /// *   UPDATE_FAILED
        /// *   UPDATE_COMPLETE
        /// *   DELETE_IN_PROGRESS
        /// *   DELETE_FAILED
        /// *   CHECK_IN_PROGRESS
        /// *   CHECK_FAILED
        /// *   CHECK_COMPLETE
        /// *   IMPORT_IN_PROGRESS
        /// *   IMPORT_FAILED
        /// *   IMPORT_COMPLETE
        /// </summary>
        [NameInMap("ResourceAttributes")]
        [Validation(Required=false)]
        public List<string> ResourceAttributes { get; set; }

        /// <summary>
        /// The name of resource property N that you want to query.
        /// </summary>
        [NameInMap("ShowResourceAttributes")]
        [Validation(Required=false)]
        public bool? ShowResourceAttributes { get; set; }

        /// <summary>
        /// The ID of the region to which the stack belongs. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
