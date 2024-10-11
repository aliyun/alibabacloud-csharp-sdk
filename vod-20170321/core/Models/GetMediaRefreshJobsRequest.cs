// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media file. It is the value of the <c>MediaIds</c> parameter that you specify when you call the <a href="~~RefreshMediaPlayUrls~~">RefreshMediaPlayUrls</a> operation. You can specify only one media ID.</para>
        /// <para>If you leave this parameter empty, information about all media files in the refresh or prefetch job specified by <c>MediaRefreshJobId</c> is returned. If you set this parameter, only the information about the specified media file is returned.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e4957b658067095869****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The ID of the refresh or prefetch job. It is the value of the MediaRefreshJobId parameter that is returned from the call to the <a href="~~RefreshMediaPlayUrls~~">RefreshMediaPlayUrls</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41d465e31957****</para>
        /// </summary>
        [NameInMap("MediaRefreshJobId")]
        [Validation(Required=false)]
        public string MediaRefreshJobId { get; set; }

    }

}
