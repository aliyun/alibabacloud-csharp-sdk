// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateConfigFileRequest : TeaModel {
        /// <summary>
        /// The name of the directory.
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The Object Storage Service (OSS) URL of the file.
        /// </summary>
        [NameInMap("ossPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// The path of the parent directory.
        /// </summary>
        [NameInMap("parentFullPath")]
        [Validation(Required=false)]
        public string ParentFullPath { get; set; }

    }

}
