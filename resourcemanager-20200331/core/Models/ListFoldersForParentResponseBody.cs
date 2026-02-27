// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListFoldersForParentResponseBody : TeaModel {
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListFoldersForParentResponseBodyFolders Folders { get; set; }
        public class ListFoldersForParentResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListFoldersForParentResponseBodyFoldersFolder> Folder { get; set; }
            public class ListFoldersForParentResponseBodyFoldersFolder : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                [NameInMap("FolderName")]
                [Validation(Required=false)]
                public string FolderName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
