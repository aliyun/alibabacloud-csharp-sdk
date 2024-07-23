// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpDBDeleteJobListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the jobs of clearing or deleting a media fingerprint library. You can obtain the job IDs from the response parameters of the <a href="https://help.aliyun.com/document_detail/209341.html">SubmitFpDBDeleteJob</a> operation. Separate multiple job IDs with commas (,). If you leave this parameter empty, the system returns the latest 20 jobs that are submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2288c6ca184c0e47098a5b665e2a12****,78dc866518b843259669df58ed30****</para>
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
