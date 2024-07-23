// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryJobListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of transcoding jobs. Separate multiple IDs with commas (,). You can query a maximum of 10 transcoding jobs at a time. You can log on to the <a href="https://mps.console.aliyun.com/overview">ApsaraVideo Media Processing (MPS) console</a> and click <b>Tasks</b> in the left-side navigation pane to obtain job IDs. Alternatively, you can obtain job IDs from the response to the <a href="https://help.aliyun.com/document_detail/29226.html">SubmitJobs</a> operation.</para>
        /// <remarks>
        /// <para> If you do not set the JobIds parameter, the <c>InvalidParameter</c> error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bb558c1cc25b45309aab5be44d19****,d1ce4d3efcb549419193f50f1fcd****</para>
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
