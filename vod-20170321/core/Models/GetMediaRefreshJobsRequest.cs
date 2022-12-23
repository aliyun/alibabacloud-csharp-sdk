// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsRequest : TeaModel {
        /// <summary>
        /// The ID of the media file. It is the value of the `MediaIds` parameter that you specify when you call the [RefreshMediaPlayUrls](~~RefreshMediaPlayUrls~~) operation. You can specify only one media ID.
        /// 
        /// If you leave this parameter empty, information about all media files in the refresh or prefetch job specified by `MediaRefreshJobId` is returned. If you set this parameter, only the information about the specified media file is returned.``
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The ID of the refresh or prefetch job. It is the value of the MediaRefreshJobId parameter that is returned from the call to the [RefreshMediaPlayUrls](~~RefreshMediaPlayUrls~~) operation.
        /// </summary>
        [NameInMap("MediaRefreshJobId")]
        [Validation(Required=false)]
        public string MediaRefreshJobId { get; set; }

    }

}
