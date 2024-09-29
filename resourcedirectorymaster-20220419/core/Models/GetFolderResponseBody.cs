// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetFolderResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the folder.</para>
        /// </summary>
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public GetFolderResponseBodyFolder Folder { get; set; }
        public class GetFolderResponseBodyFolder : TeaModel {
            /// <summary>
            /// <para>The time when the folder was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-15T06:39:08.521Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-Jyl5U7****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The name of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Applications</para>
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            /// <summary>
            /// <para>The ID of the parent folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-Wm****</para>
            /// </summary>
            [NameInMap("ParentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }

            /// <summary>
            /// <para>The path of the folder in the resource directory.</para>
            /// </summary>
            [NameInMap("ResourceDirectoryPath")]
            [Validation(Required=false)]
            public string ResourceDirectoryPath { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2CBCA30-C8DD-423E-B4AD-4FB694C9180C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
