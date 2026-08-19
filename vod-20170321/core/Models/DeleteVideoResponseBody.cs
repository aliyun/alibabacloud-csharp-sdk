// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteVideoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of video IDs for which the operation is forbidden.</para>
        /// <remarks>
        /// <para>This is typically caused by insufficient <a href="https://help.aliyun.com/document_detail/113600.html">permissions</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ForbiddenVideoIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenVideoIds { get; set; }

        /// <summary>
        /// <para>The list of custom IDs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistReferenceIds")]
        [Validation(Required=false)]
        public List<string> NonExistReferenceIds { get; set; }

        /// <summary>
        /// <para>The list of video IDs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4EBD2BF-5EB0-4476-8829-9D94E1B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
