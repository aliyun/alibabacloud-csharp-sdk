// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class UpdateAutomateResponseConfigStatusRequest : TeaModel {
        /// <summary>
        /// The IDs of the automatic response rules. The value is a JSON array.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Specifies whether the rule is enabled. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("InUse")]
        [Validation(Required=false)]
        public bool? InUse { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the account that you switch from the management account.
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// The type of the view. Valid values:
        /// - 0: the current Alibaba Cloud account
        /// - 1: the global account
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
