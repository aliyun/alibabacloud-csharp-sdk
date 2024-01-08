// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListResourcesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListResourcesResponseBodyData Data { get; set; }
        public class ListResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates the marker after which the returned list begins.
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// The maximum number of entries returned per page.
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            /// <summary>
            /// The list of resources.
            /// </summary>
            [NameInMap("resources")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyDataResources> Resources { get; set; }
            public class ListResourcesResponseBodyDataResources : TeaModel {
                /// <summary>
                /// The remarks.
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The Base64-encoded 128-bit MD5 hash value of the HTTP request body.
                /// </summary>
                [NameInMap("contentMD5")]
                [Validation(Required=false)]
                public string ContentMD5 { get; set; }

                /// <summary>
                /// The time when the resource was created.
                /// </summary>
                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                /// <summary>
                /// The display name.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The time when the resource was modified.
                /// </summary>
                [NameInMap("lastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                /// <summary>
                /// The user who updated the resource.
                /// </summary>
                [NameInMap("lastUpdator")]
                [Validation(Required=false)]
                public string LastUpdator { get; set; }

                /// <summary>
                /// The name of the resource.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The owner of the resource.
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The schema to which the resource belongs.
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// The size of the resource.
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The resource type.
                /// 
                /// Valid values:
                /// 
                /// *   file
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   py
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   jar
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   volumefile
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   table
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
