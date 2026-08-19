// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMezzaninesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of custom IDs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistReferenceIds")]
        [Validation(Required=false)]
        public List<string> NonExistReferenceIds { get; set; }

        /// <summary>
        /// <para>The list of audio or video IDs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of audio or video IDs that cannot be deleted.</para>
        /// <remarks>
        /// <para>This is typically because the source file is used as the original stream (if the video transcoding pattern is no transcoding or asynchronous transcoding, the source file is used as the original stream for playback and cannot be deleted by default) or because of insufficient <a href="https://help.aliyun.com/document_detail/113600.html">permissions</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnRemoveableVideoIds")]
        [Validation(Required=false)]
        public List<string> UnRemoveableVideoIds { get; set; }

    }

}
