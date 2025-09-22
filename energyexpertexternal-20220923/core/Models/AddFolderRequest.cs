// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AddFolderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“abc” “1234”</para>
        /// </summary>
        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot; ：parent folder is root
        /// &quot;4b648f6d11344f258df876cbdc24dc1f&quot; ： folderId</para>
        /// </summary>
        [NameInMap("parentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

    }

}
