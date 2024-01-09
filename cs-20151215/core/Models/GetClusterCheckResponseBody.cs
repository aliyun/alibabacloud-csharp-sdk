// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterCheckResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("check_id")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        /// <summary>
        /// The list of check items.
        /// </summary>
        [NameInMap("check_items")]
        [Validation(Required=false)]
        public Dictionary<string, List<Dictionary<string, object>>> CheckItems { get; set; }

        /// <summary>
        /// The time when the cluster check task was created.
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The time when the cluster check task was completed.
        /// </summary>
        [NameInMap("finished_at")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// The message that indicates the status of the cluster check task.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The status of the cluster check.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The check method.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
