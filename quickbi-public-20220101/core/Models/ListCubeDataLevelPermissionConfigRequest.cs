// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListCubeDataLevelPermissionConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the training dataset that you want to remove from the specified custom linguistic model.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// The type of the dataset row and column permission. Valid values:
        /// 
        /// *   ROW_LEVEL: row-level permissions
        /// *   COLUMN_LEVEL: column-level permissions
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
