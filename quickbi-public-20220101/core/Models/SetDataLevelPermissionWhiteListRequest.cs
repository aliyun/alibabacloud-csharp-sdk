// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SetDataLevelPermissionWhiteListRequest : TeaModel {
        /// <summary>
        /// { "ruleType": "ROW_LEVEL", // The row-level permission type. "usersModel": { "userGroups": [ "0d5fb19b- ***-1248 fc27ca51", // The ID of the user group. "3d2c23d4-***-f6390f325c2d" ], "users": [ "4334 ***358", // Quick BI the UserID of the user. "Huang***3fa822" ] }, "cubeId": "7c7223ae-31d1-4d2f-b11f-3c744528014b" }
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WhiteListModel")]
        [Validation(Required=false)]
        public string WhiteListModel { get; set; }

    }

}
