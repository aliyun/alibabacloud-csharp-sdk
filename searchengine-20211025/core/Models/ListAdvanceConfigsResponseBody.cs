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
        /// The advanced configurations.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAdvanceConfigsResponseBodyResult> Result { get; set; }
        public class ListAdvanceConfigsResponseBodyResult : TeaModel {
            /// <summary>
            /// *   The type of the advanced configuration. Valid values: -ONLINE: online configuration
            /// *   \\-ONLINE_CAVA: online Cava configuration
            /// *   \\-ONLINE_PLUGIN: online plug-in configuration
            /// *   \\-ONLINE_QUERY: query configuration
            /// *   \\-OFFLINE_DICT: offline dictionary configuration
            /// *   \\-OFFLINE_TABLE: offline table configuration
            /// *   \\-OFFLINE_COMMON: offline configuration
            /// *   \\-OFFLINE_PLUGIN: offline plug-in configuration
            /// *   \\-OFFLINE_INDEX: index configuration
            /// </summary>
            [NameInMap("advanceConfigType")]
            [Validation(Required=false)]
            public string AdvanceConfigType { get; set; }

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
            /// The Alibaba Cloud account ID of the user who created the advanced configuration.
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

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
            public List<ListAdvanceConfigsResponseBodyResultFiles> Files { get; set; }
            public class ListAdvanceConfigsResponseBodyResultFiles : TeaModel {
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
                /// Indicates whether the file is a template. Valid values: true and false.
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
