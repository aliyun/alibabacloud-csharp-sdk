// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class CreateFolderRequest : TeaModel {
        /// <summary>
        /// <para>The name of the folder.</para>
        /// <para>The name must be 1 to 24 characters in length and can contain letters, digits, underscores (_), periods (.),and hyphens (-).</para>
        /// <para>This parameter is required.</para>
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

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFolderRequestTag> Tag { get; set; }
        public class CreateFolderRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
