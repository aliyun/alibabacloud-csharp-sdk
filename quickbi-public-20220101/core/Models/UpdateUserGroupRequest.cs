// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserGroupRequest : TeaModel {
        /// <summary>
        /// The description of the user group.
        /// 
        /// *   Format verification: Maximum length 255
        /// *   Special format verification: Chinese and English digits_ \\ / | () ] [
        /// </summary>
        [NameInMap("UserGroupDescription")]
        [Validation(Required=false)]
        public string UserGroupDescription { get; set; }

        /// <summary>
        /// The ID of the user group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// The name of the user group.
        /// 
        /// *   Format verification: Maximum length 255
        /// *   Special format verification: Chinese and English digits_ \\ / | () ] [
        /// </summary>
        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
