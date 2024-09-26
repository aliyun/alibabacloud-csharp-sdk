// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceFoldersResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging result for the folders.</para>
        /// </summary>
        [NameInMap("FolderPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceFoldersResponseBodyFolderPagingResult FolderPagingResult { get; set; }
        public class ListDataServiceFoldersResponseBodyFolderPagingResult : TeaModel {
            /// <summary>
            /// <para>The folders.</para>
            /// </summary>
            [NameInMap("Folders")]
            [Validation(Required=false)]
            public List<ListDataServiceFoldersResponseBodyFolderPagingResultFolders> Folders { get; set; }
            public class ListDataServiceFoldersResponseBodyFolderPagingResultFolders : TeaModel {
                /// <summary>
                /// <para>The time when the folder was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-24T18:37:51+0800</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The folder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public long? FolderId { get; set; }

                /// <summary>
                /// <para>The name of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("FolderName")]
                [Validation(Required=false)]
                public string FolderName { get; set; }

                /// <summary>
                /// <para>The ID of the business process to which the folder belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds_1234</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The time when the folder was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-24T18:37:51+0800</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the parent folder. The ID of the root folder in a business process is 0, and the ID of a folder created by a user in a business process is greater than 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10002</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>The page number. The value of this parameter is the same as that of the PageNumber parameter in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
