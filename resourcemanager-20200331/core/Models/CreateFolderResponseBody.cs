// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateFolderResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the folder.</para>
        /// </summary>
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public CreateFolderResponseBodyFolder Folder { get; set; }
        public class CreateFolderResponseBodyFolder : TeaModel {
            /// <summary>
            /// <para>The time when the folder was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-19T09:34:50.757Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-u8B321****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The name of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rdFolder</para>
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            /// <summary>
            /// <para>The ID of the parent folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-b1****</para>
            /// </summary>
            [NameInMap("ParentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }

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
