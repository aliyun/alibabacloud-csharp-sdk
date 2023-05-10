// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the stack group.
        /// 
        /// >  You must specify one of the StackGroupName and StackGroupId parameters.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The details of the stack group.
        /// </summary>
        [NameInMap("StackGroupId")]
        [Validation(Required=false)]
        public string StackGroupId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
