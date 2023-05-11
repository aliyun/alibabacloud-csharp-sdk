// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddDataLevelPermissionWhiteListRequest : TeaModel {
        /// <summary>
        /// The ID of the training dataset that you want to remove from the specified custom linguistic model.
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// Operation Type: You can set this parameter to one of the following values.
        /// 
        /// *   ADD: Add a whitelist
        /// *   DELETE: deletes a whitelist.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The type of row-level permissions.
        /// 
        /// *   ROW_LEVEL: row-level permissions,
        /// *   COLUMN_LEVEL: column-level permissions
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public string TargetIds { get; set; }

        /// <summary>
        /// Modify the type of the whitelist:
        /// 
        /// *   1: user
        /// *   2: user group
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
