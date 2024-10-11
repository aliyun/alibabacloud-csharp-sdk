// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitSnapshotJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-5EB0-4AF6-D7393642****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the snapshot job.</para>
        /// </summary>
        [NameInMap("SnapshotJob")]
        [Validation(Required=false)]
        public SubmitSnapshotJobResponseBodySnapshotJob SnapshotJob { get; set; }
        public class SubmitSnapshotJobResponseBodySnapshotJob : TeaModel {
            /// <summary>
            /// <para>The ID of the snapshot job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad90a501b1b94b72374ad0050464****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

    }

}
