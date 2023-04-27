// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowOwnerRequest : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("NewOwnerId")]
        [Validation(Required=false)]
        public string NewOwnerId { get; set; }

        /// <summary>
        /// The user ID of the new owner. You can call the [GetUser](~~147098~~) or [ListUsers](~~141938~~) operation to query the user ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
