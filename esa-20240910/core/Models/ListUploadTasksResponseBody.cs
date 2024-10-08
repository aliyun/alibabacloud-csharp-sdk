// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUploadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListUploadTasksResponseBodyTasks> Tasks { get; set; }
        public class ListUploadTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-26T01:56:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>invalid url</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidUrl,InvalidDomain</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>159253299357****</para>
            /// </summary>
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>purge_file_task</para>
            /// </summary>
            [NameInMap("UploadTaskName")]
            [Validation(Required=false)]
            public string UploadTaskName { get; set; }

        }

    }

}
