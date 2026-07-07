// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetFailFileRequest : TeaModel {
        /// <summary>
        /// <para>The site ID. You can obtain this by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The file upload task ID. You can obtain this by calling the <a href="https://help.aliyun.com/document_detail/2850466.html">UploadFile</a> operation to create an upload task, or by calling the <a href="https://help.aliyun.com/document_detail/2851127.html">ListUploadTasks</a> operation to query existing tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593805857882113</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public long? UploadId { get; set; }

    }

}
