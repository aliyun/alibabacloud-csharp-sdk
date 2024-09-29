// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListAncestorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the folders.</para>
        /// </summary>
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListAncestorsResponseBodyFolders Folders { get; set; }
        public class ListAncestorsResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListAncestorsResponseBodyFoldersFolder> Folder { get; set; }
            public class ListAncestorsResponseBodyFoldersFolder : TeaModel {
                /// <summary>
                /// <para>The time when the folder was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-18T10:03:35.217Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-b1****</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>The name of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("FolderName")]
                [Validation(Required=false)]
                public string FolderName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83AFBEB6-DC03-406E-9686-867461FF6698</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
