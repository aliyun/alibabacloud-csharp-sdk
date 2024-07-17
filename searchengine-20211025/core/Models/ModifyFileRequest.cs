// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyFileRequest : TeaModel {
        /// <summary>
        /// The file content.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The number of shards.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public int? Partition { get; set; }

        /// <summary>
        /// The name of the file in the full path
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

    }

}
