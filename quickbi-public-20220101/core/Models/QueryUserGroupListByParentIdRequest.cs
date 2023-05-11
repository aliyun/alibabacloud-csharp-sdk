// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserGroupListByParentIdRequest : TeaModel {
        /// <summary>
        /// The ID of the parent user group.
        /// 
        /// *   If you enter the ID of the parent user group, you can obtain the information of the child user group under this ID.
        /// *   If you enter -1, you can obtain the sub-user group information under the root directory.
        /// </summary>
        [NameInMap("ParentUserGroupId")]
        [Validation(Required=false)]
        public string ParentUserGroupId { get; set; }

    }

}
