// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteVideoResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the videos that cannot be deleted.</para>
        /// <remarks>
        /// <para>Generally, videos cannot be deleted if you do not have the required <a href="https://help.aliyun.com/document_detail/113600.html">permissions</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ForbiddenVideoIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenVideoIds { get; set; }

        [NameInMap("NonExistReferenceIds")]
        [Validation(Required=false)]
        public List<string> NonExistReferenceIds { get; set; }

        /// <summary>
        /// <para>The IDs of the videos that do not exist.</para>
        /// <remarks>
        /// <para>If the list of videos to be deleted contains one or more videos that do not exist, the IDs of these non-existing videos are returned. If none of the videos in the list exists, a 404 error is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4EBD2BF-5EB0-4476-8829-9D94E1B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
