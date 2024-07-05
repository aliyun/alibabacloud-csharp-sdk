// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteVideoResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the videos that cannot be deleted.
        /// > Generally, videos cannot be deleted if you do not have the required [permissions](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("ForbiddenVideoIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenVideoIds { get; set; }

        /// <summary>
        /// The IDs of the videos that do not exist.
        /// > If the list of videos to be deleted contains one or more videos that do not exist, the IDs of these non-existing videos are returned. If none of the videos in the list exists, a 404 error is returned.
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
