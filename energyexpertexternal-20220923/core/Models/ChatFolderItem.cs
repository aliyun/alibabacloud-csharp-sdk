// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatFolderItem : TeaModel {
        /// <summary>
        /// <para>Folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>Folder name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default folder</para>
        /// </summary>
        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// <para>Subfolder list.</para>
        /// </summary>
        [NameInMap("subFolders")]
        [Validation(Required=false)]
        public List<ChatItem> SubFolders { get; set; }

    }

}
