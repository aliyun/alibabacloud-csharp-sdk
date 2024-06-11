// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// The description.
        /// 
        /// The value can be up to 128 characters in length.
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The name of the user group.
        /// 
        /// The name must be 1 to 64 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_).
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
