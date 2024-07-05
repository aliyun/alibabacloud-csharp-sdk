// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the media files that cannot be operated on. In most cases, media files cannot be operated on because you are not authorized to perform the operations. For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public string ForbiddenMediaIds { get; set; }

        /// <summary>
        /// The ID of the refresh or prefetch task.
        /// </summary>
        [NameInMap("MediaRefreshJobId")]
        [Validation(Required=false)]
        public string MediaRefreshJobId { get; set; }

        /// <summary>
        /// The IDs of the media files that do not exist.
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public string NonExistMediaIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
