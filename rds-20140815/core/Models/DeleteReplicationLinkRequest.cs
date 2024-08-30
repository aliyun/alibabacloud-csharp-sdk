// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteReplicationLinkRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to promote the disaster recovery instance to the primary instance. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PromoteToMaster")]
        [Validation(Required=false)]
        public bool? PromoteToMaster { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
