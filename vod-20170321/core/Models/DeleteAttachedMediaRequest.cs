// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAttachedMediaRequest : TeaModel {
        /// <summary>
        /// The ID of the auxiliary media asset that you want to delete. You can obtain the ID of the auxiliary media asset from the MediaId parameter in the response to the [CreateUploadAttachedMedia](https://help.aliyun.com/document_detail/98467.html) operation.
        /// 
        /// *   Separate multiple IDs with commas (,).
        /// *   You can specify a maximum of 20 IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
