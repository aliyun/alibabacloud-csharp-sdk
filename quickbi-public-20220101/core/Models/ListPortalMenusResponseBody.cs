// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListPortalMenusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A JSON string that levels the details of the portal menu list. Valid values:
        /// 
        /// *   menuType: the type of the menu.
        /// 
        ///     *   0: dashboard
        ///     *   1: outer chain
        ///     *   2: workbook
        ///     *   4: directory folder
        ///     *   5: form filling
        ///     *   6: self-service data retrieval
        /// 
        /// *   menuId: menu ID
        /// 
        /// *   uri: ID or URL of the resource associated with the menu
        /// 
        /// *   showOnlyWithAccess: Authorized Only Visible
        /// 
        /// *   menuName: menu display name
        /// 
        /// *   dependentPermisson: whether the report resource associated with the menu has permissions
        /// 
        /// *   children: submenu
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
