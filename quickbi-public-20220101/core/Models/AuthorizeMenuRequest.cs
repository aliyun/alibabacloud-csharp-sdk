// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AuthorizeMenuRequest : TeaModel {
        /// <summary>
        /// Authorizes the permissions of the menu. Valid values:
        /// 
        /// *   1: view
        /// *   3: View + Export (default)
        /// </summary>
        [NameInMap("AuthPointsValue")]
        [Validation(Required=false)]
        public int? AuthPointsValue { get; set; }

        /// <summary>
        /// The ID of the BI portal.
        /// </summary>
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        /// <summary>
        /// The menu ID of the BI portal leaf node.
        /// 
        /// *   The directory menu cannot be authorized.
        /// *   You can upload multiple parameters at a time. Separate multiple IDs with commas (,). The maximum number of parameters that can be modified at a time is 100.
        /// </summary>
        [NameInMap("MenuIds")]
        [Validation(Required=false)]
        public string MenuIds { get; set; }

        /// <summary>
        /// The IDs of the user groups.
        /// 
        /// *   You can upload multiple parameters at a time. Separate multiple IDs with commas (,). The maximum number of parameters that can be modified at a time is 200.
        /// *   UserGroupIds and UserIds cannot be empty at the same time
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        /// <summary>
        /// The IDs of the end users. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.
        /// 
        /// *   You can upload multiple parameters at a time. Separate multiple IDs with commas (,). The maximum number of parameters that can be modified at a time is 200.
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
