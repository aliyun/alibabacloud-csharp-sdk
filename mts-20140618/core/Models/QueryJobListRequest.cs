// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryJobListRequest : TeaModel {
        /// <summary>
        /// The IDs of transcoding jobs. Separate multiple IDs with commas (,). You can query a maximum of 10 transcoding jobs at a time. You can log on to the [ApsaraVideo Media Processing (MPS) console](https://mps.console.aliyun.com/overview) and click **Tasks** in the left-side navigation pane to obtain job IDs. Alternatively, you can obtain job IDs from the response to the [SubmitJobs](https://help.aliyun.com/document_detail/29226.html) operation.
        /// 
        /// >  If you do not set the JobIds parameter, the `InvalidParameter` error code is returned.
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
