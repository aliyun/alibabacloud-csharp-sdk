// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the videos that cannot be modified. Generally, videos cannot be modified if you do not have required <a href="https://help.aliyun.com/document_detail/113600.html">permissions</a>.</para>
        /// </summary>
        [NameInMap("ForbiddenVideoIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenVideoIds { get; set; }

        /// <summary>
        /// <para>The IDs of the videos that do not exist.</para>
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

    }

}
