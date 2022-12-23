// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteDynamicImageRequest : TeaModel {
        /// <summary>
        /// The IDs of the animated stickers.
        /// 
        /// - Separate multiple IDs with commas (,). You can specify a maximum of 10 IDs.
        /// - If you do not set this parameter, the system finds the video specified by the VideoId parameter and deletes the information about the animated stickers associated with the video. If more than 10 animated stickers are associated with the video specified by the VideoId parameter, the deletion request is denied.
        /// </summary>
        [NameInMap("DynamicImageIds")]
        [Validation(Required=false)]
        public string DynamicImageIds { get; set; }

        /// <summary>
        /// The ID of the video associated with the animated stickers whose information you want to delete.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
