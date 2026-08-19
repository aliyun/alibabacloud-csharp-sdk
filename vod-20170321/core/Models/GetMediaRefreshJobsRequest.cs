// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsRequest : TeaModel {
        /// <summary>
        /// <para>The audio or video ID, which is the <c>MediaIds</c> value specified when calling the <a href="https://help.aliyun.com/document_detail/431095.html">SubmitMediaRefreshJob</a> operation. Only one audio or video ID can be specified.</para>
        /// <para>If this parameter is not specified, task information for all audio or video files under the specified <c>MediaRefreshJobId</c> is returned. If this parameter is specified, only the task information for the specified audio or video ID under the <c>MediaRefreshJobId</c> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e4957b658067095869****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The ID of the audio or video purge or prefetch task. This is the value of MediaRefreshJobId returned by the <a href="https://help.aliyun.com/document_detail/431095.html">SubmitMediaRefreshJob</a> operation.</para>
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
