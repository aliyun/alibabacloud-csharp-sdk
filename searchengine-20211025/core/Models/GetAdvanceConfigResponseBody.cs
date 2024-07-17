// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetAdvanceConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAdvanceConfigResponseBodyResult Result { get; set; }
        public class GetAdvanceConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// The content of the advanced configuration that is returned.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The type of the configuration content. Valid values: FILE, GIT, HTTP, and ODPS.
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// The description of the advanced configuration.
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The files.
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<GetAdvanceConfigResponseBodyResultFiles> Files { get; set; }
            public class GetAdvanceConfigResponseBodyResultFiles : TeaModel {
                /// <summary>
                /// The file path.
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
                /// Indicates whether the file is a container.
                /// </summary>
                [NameInMap("isTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// The file name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The name of the advanced configuration.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the advanced configuration. Valid values: drafting: The advanced configuration is in the draft state. used: The advanced configuration is being used. unused: The advanced configuration is not used. trash: The advanced configuration is being deleted.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the advanced configuration was updated.
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
