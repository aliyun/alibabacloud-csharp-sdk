// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupAddOrUpdateShrinkRequest : TeaModel {
        /// <summary>
        /// The information about the user group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public string UserGroupsShrink { get; set; }

    }

}
