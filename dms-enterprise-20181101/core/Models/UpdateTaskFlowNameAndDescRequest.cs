// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowNameAndDescRequest : TeaModel {
        /// <summary>
        /// The description that you want to specify for the task flow.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("DagName")]
        [Validation(Required=false)]
        public string DagName { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The new name that you want to specify for the task flow.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
