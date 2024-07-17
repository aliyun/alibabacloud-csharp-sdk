// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateConfigDirRequest : TeaModel {
        /// <summary>
        /// The directory name.
        /// </summary>
        [NameInMap("dirName")]
        [Validation(Required=false)]
        public string DirName { get; set; }

        /// <summary>
        /// The path of the parent directory.
        /// </summary>
        [NameInMap("parentFullPath")]
        [Validation(Required=false)]
        public string ParentFullPath { get; set; }

    }

}
