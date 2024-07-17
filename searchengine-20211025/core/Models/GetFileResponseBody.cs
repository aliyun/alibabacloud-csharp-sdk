// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetFileResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The index information.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFileResponseBodyResult Result { get; set; }
        public class GetFileResponseBodyResult : TeaModel {
            /// <summary>
            /// The file content.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The data source.
            /// </summary>
            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// The full path of the file.
            /// </summary>
            [NameInMap("fullPathName")]
            [Validation(Required=false)]
            public string FullPathName { get; set; }

            /// <summary>
            /// Indicates whether the file is a directory.
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// The file name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of shards.
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public long? Partition { get; set; }

        }

    }

}
