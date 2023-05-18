// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupRequest : TeaModel {
        /// <summary>
        /// The name of the stack group. The name must be unique within a region.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). It must start with a digit or letter.
        /// 
        /// >  You must specify one of the StackGroupName and StackGroupId parameters.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("StackGroupId")]
        [Validation(Required=false)]
        public string StackGroupId { get; set; }

        /// <summary>
        /// The ID of the stack group.
        /// 
        /// >  You must specify one of the StackGroupName and StackGroupId parameters.
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
