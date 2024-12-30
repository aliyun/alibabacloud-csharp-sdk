// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class TrashFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// <para>If an empty string is returned, the file or folder is moved to the recycle bin.</para>
        /// <para>If a non-empty string is returned, an asynchronous task is required. You can call the GetAsyncTask operation to obtain the information about an asynchronous task based on the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13ebd3a24dba4166b1527add676ef2866051b4d5dele16</para>
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
        /// <para>The ID of the file or folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4221bf6e6ab43c255edc4463bf3a6f5f5d317406</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

    }

}
