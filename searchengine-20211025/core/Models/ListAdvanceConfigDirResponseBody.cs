// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigDirResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The advanced configuration files.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAdvanceConfigDirResponseBodyResult> Result { get; set; }
        public class ListAdvanceConfigDirResponseBodyResult : TeaModel {
            /// <summary>
            /// The absolute path in which the file is stored.
            /// </summary>
            [NameInMap("fullPathName")]
            [Validation(Required=false)]
            public string FullPathName { get; set; }

            /// <summary>
            /// Indicates whether the file is a directory. Valid values: true and false.
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// Indicates whether the file is a template. Valid values: **true** and **false**.
            /// </summary>
            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            /// <summary>
            /// The cluster name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
