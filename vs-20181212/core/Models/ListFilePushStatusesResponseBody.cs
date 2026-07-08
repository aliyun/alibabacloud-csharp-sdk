// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListFilePushStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of file push status records.</para>
        /// </summary>
        [NameInMap("PushStatuses")]
        [Validation(Required=false)]
        public List<ListFilePushStatusesResponseBodyPushStatuses> PushStatuses { get; set; }
        public class ListFilePushStatusesResponseBodyPushStatuses : TeaModel {
            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-1671accd4dafdag3er256cvgewt13f7141db2f7</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myfile</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The scheduled push start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-26T16:32:20+08:00</para>
            /// </summary>
            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// <para>The cloud application service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <para>The file push status. Valid values:</para>
            /// <ol>
            /// <item><description><para>Created</para>
            /// </description></item>
            /// <item><description><para>Doing</para>
            /// </description></item>
            /// <item><description><para>Success: desired state</para>
            /// </description></item>
            /// <item><description><para>Failed: desired state</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>push success</para>
            /// </summary>
            [NameInMap("StatusDescription")]
            [Validation(Required=false)]
            public string StatusDescription { get; set; }

            /// <summary>
            /// <para>The latest update time of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-26T17:02:10+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matching file push records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
