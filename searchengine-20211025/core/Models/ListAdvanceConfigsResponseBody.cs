// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of advanced configurations.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAdvanceConfigsResponseBodyResult> Result { get; set; }
        public class ListAdvanceConfigsResponseBodyResult : TeaModel {
            [NameInMap("advanceConfigType")]
            [Validation(Required=false)]
            public string AdvanceConfigType { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The list of file names.
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<ListAdvanceConfigsResponseBodyResultFiles> Files { get; set; }
            public class ListAdvanceConfigsResponseBodyResultFiles : TeaModel {
                /// <summary>
                /// The name of the absolute path.
                /// </summary>
                [NameInMap("fullPathName")]
                [Validation(Required=false)]
                public string FullPathName { get; set; }

                /// <summary>
                /// Indicates whether it is a directory. Valid values: true and false. true indicates that it is a directory, and false indicates that it is not a directory.
                /// </summary>
                [NameInMap("isDir")]
                [Validation(Required=false)]
                public bool? IsDir { get; set; }

                /// <summary>
                /// Indicates whether it is a template. Valid values: true and false. true indicates that it is a directory, and false indicates that it is not a directory.
                /// </summary>
                [NameInMap("isTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// The name of the file.
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
            /// The state of the advanced configuration. Valid values: drafting, used, unused, and trash. drafting indicates that the advanced configuration is a draft. used indicates that the advanced configuration is in use. unused indicates that the advanced configuration is unused. trash indicates that the advanced configuration is being deleted.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The update time.
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
