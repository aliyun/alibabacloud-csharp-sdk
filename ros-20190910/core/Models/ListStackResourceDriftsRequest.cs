// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourceDriftsRequest : TeaModel {
        /// <summary>
        /// The type of the resource.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The resource properties as defined in the template, in JSON format.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The time when the resource drift detection operation was initiated.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The drift status of the resource. Valid values:
        /// 
        /// *   DELETED: The actual configuration of the resource differs from its expected template configuration because the resource had been deleted.
        /// *   MODIFIED: The actual configuration of the resource differs from its expected template configuration.
        /// *   NOT_CHECKED: ROS has not checked whether the actual configuration of the resource differs from its expected template configuration.
        /// *   IN_SYNC: The actual configuration of the resource matches its expected template configuration.
        /// </summary>
        [NameInMap("ResourceDriftStatus")]
        [Validation(Required=false)]
        public List<string> ResourceDriftStatus { get; set; }

        /// <summary>
        /// The physical ID of the resource.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
