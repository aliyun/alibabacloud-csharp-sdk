// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class MoveFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// <para>If an empty string is returned, the file is moved.</para>
        /// <para>If a non-empty string is returned, an asynchronous task is required. You can call the GetAsyncTask operation to obtain the information about an asynchronous task based on the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23ebd1a24dba4166b1527add476ef2866051b4d5del106</para>
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
        /// <para>Indicates whether the file already exists in the destination directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("exist")]
        [Validation(Required=false)]
        public bool? Exist { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileid1</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

    }

}
