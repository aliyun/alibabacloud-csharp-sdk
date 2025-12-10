// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class UpdateExperimentFolderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>folder1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>folder-xzf7t785nka4c2334</para>
        /// </summary>
        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

    }

}
