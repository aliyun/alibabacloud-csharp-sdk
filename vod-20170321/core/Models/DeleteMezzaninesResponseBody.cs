// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMezzaninesResponseBody : TeaModel {
        [NameInMap("NonExistReferenceIds")]
        [Validation(Required=false)]
        public List<string> NonExistReferenceIds { get; set; }

        /// <summary>
        /// <para>The IDs of the audio or video files that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IDs of the audio or video files whose source files cannot be deleted.</para>
        /// <remarks>
        /// <para> In most cases, source files cannot be deleted if they are used for original-quality playback or you do not have required permissions to delete them. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnRemoveableVideoIds")]
        [Validation(Required=false)]
        public List<string> UnRemoveableVideoIds { get; set; }

    }

}
