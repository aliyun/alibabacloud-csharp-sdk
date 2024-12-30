// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CopyFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// <para>If a file is copied, this parameter is not returned. If a folder is copied, the folder is asynchronously copied in the background and this parameter is returned. You can call the GetAsyncTask operation to query the information about the asynchronous task based on the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000e89fb-cf8f-11e9-8ab4-b6e980803a3b</para>
        /// </summary>
        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The ID of the copied file or folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4221bf6e6ab43a255edc4463bffa6f5f5d317401</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

    }

}
