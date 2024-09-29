// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class UpdateFolderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the folder.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-u8B321****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The new name of the folder.</para>
        /// <para>The name must be 1 to 24 characters in length and can contain letters, digits, underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdFolder</para>
        /// </summary>
        [NameInMap("NewFolderName")]
        [Validation(Required=false)]
        public string NewFolderName { get; set; }

    }

}
