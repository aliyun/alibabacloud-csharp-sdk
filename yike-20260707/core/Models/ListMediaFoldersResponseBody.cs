// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class ListMediaFoldersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of folders.</para>
        /// </summary>
        [NameInMap("FolderList")]
        [Validation(Required=false)]
        public List<ListMediaFoldersResponseBodyFolderList> FolderList { get; set; }
        public class ListMediaFoldersResponseBodyFolderList : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The folder ID. The ID of the default folder is fixed to <c>fd_{ProductionId}_default</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd_pd_1585***_default</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The folder name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default folder</para>
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            /// <summary>
            /// <para>Indicates whether the folder is the default folder. Each project has exactly one default folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the folder belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_1585***</para>
            /// </summary>
            [NameInMap("ProductionId")]
            [Validation(Required=false)]
            public string ProductionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B6524F7-*****-A55F-B7DEA1EC628A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
