// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUploadTaskRequest : TeaModel {
        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required when querying an upload task..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The file upload task ID, which is assigned when you call the <a href="https://help.aliyun.com/document_detail/2850466.html">UploadFile</a> operation.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required and must be a valid task ID returned by the UploadFile operation. If this parameter is not provided or the specified ID does not exist, an InvalidParameters (400) error is returned..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>159253299357****</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public long? UploadId { get; set; }

    }

}
