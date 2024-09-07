// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class DeleteUsersShrinkRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The users that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string UserShrink { get; set; }

    }

}
