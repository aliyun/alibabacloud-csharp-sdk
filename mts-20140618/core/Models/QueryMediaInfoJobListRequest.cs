// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaInfoJobListRequest : TeaModel {
        /// <summary>
        /// The IDs of the media information analysis jobs.
        /// 
        /// *   You can query up to 10 jobs at a time. Separate multiple IDs with commas (,).
        /// *   You can obtain the details from the response parameters of the [SubmitMediaInfoJob](https://help.aliyun.com/document_detail/602827.html) operation.
        /// 
        /// >  If you do not specify the JobIds parameter, the **InvalidParameter** error code is returned.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaInfoJobIds")]
        [Validation(Required=false)]
        public string MediaInfoJobIds { get; set; }

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
