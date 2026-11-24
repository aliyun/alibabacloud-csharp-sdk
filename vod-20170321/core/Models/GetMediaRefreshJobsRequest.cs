// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsRequest : TeaModel {
        /// <summary>
        /// <para>The audio or video ID. The value is the <c>MediaIds</c> parameter passed when you call the <a href="https://help.aliyun.com/document_detail/431095.html">Submit audio and video refresh or prefetch tasks</a> API operation. You can specify only one audio or video ID.</para>
        /// <para>If you do not specify this parameter, the task information of all audio and video files under the <c>MediaRefreshJobId</c> is queried. If you specify this parameter, only the task information of the specified audio or video file under the <c>MediaRefreshJobId</c> is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e4957b658067095869****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The task ID of the audio or video refresh or prefetch task. The value is the MediaRefreshJobId parameter returned by the <a href="https://help.aliyun.com/document_detail/431095.html">Submit audio and video refresh or prefetch tasks</a> API operation.</para>
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
