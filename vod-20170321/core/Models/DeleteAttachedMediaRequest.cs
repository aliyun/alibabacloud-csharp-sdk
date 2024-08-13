// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAttachedMediaRequest : TeaModel {
        /// <summary>
        /// The ID of the auxiliary media asset that you want to delete.
        /// 
        /// *   Separate multiple IDs with commas (,). You can specify up to 20 IDs.
        /// *   You can obtain the ID from the response to the [CreateUploadAttachedMedia](~~CreateUploadAttachedMedia~~) operation that you call to obtain the upload URL and credential.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
