// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class RollbackApplicationRequest : TeaModel {
        /// <summary>
        /// The application ID. You can call the ListApplication operation to query the application ID. For more information, see [ListApplication](~~423162~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The number of batches for the rollback. Default value: 1. Valid values: 1 to 5.
        /// </summary>
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public int? Batch { get; set; }

        /// <summary>
        /// The wait time between batches. Default value: 0. The default value indicates no wait time. Valid values: 0 to 5. Unit: minutes.
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// The application group ID. You can call the ListDeployGroup operation to query the application group ID. For more information, see [ListDeployGroup](~~423184~~).
        /// 
        /// If you need to roll back the application in all application groups, set this parameter to `all`.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The historical version to which you want to roll back the application. Call the ListHistoryDeployVersion operation to query the historical versions of the application. Then, set this parameter based on the returned value of `PackageVersion`. For more information, see [ListHistoryDeployVersion](~~423163~~).
        /// </summary>
        [NameInMap("HistoryVersion")]
        [Validation(Required=false)]
        public string HistoryVersion { get; set; }

    }

}
