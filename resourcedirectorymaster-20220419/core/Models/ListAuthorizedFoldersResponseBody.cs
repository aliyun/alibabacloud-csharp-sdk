// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListAuthorizedFoldersResponseBody : TeaModel {
        /// <summary>
        /// <para>The folders.</para>
        /// </summary>
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListAuthorizedFoldersResponseBodyFolders Folders { get; set; }
        public class ListAuthorizedFoldersResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListAuthorizedFoldersResponseBodyFoldersFolder> Folder { get; set; }
            public class ListAuthorizedFoldersResponseBodyFoldersFolder : TeaModel {
                /// <summary>
                /// <para>The ID of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fd-bVaRIG****</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>The name of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project-1</para>
                /// </summary>
                [NameInMap("FolderName")]
                [Validation(Required=false)]
                public string FolderName { get; set; }

                /// <summary>
                /// <para>The RDPath of the folder.</para>
                /// </summary>
                [NameInMap("ResourceDirectoryPath")]
                [Validation(Required=false)]
                public string ResourceDirectoryPath { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
