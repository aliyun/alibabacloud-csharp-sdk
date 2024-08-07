// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpFileDeleteJobListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the jobs of deleting media files from a media fingerprint library. You can obtain the job IDs from the response parameters of the <a href="https://help.aliyun.com/document_detail/209274.html">SubmitFpFileDeleteJob</a> operation. Separate multiple job IDs with commas (,). If you leave this parameter empty, the system returns the latest 20 jobs that are submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d98459323c024947a104f6a50cbf****,c2dc694696f1441591c5012a73c1****</para>
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
