// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetIndexVersionResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The clusters.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetIndexVersionResponseBodyResult Result { get; set; }
        public class GetIndexVersionResponseBodyResult : TeaModel {
            /// <summary>
            /// The cluster name.
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// The index versions.
            /// </summary>
            [NameInMap("indexVersions")]
            [Validation(Required=false)]
            public List<GetIndexVersionResponseBodyResultIndexVersions> IndexVersions { get; set; }
            public class GetIndexVersionResponseBodyResultIndexVersions : TeaModel {
                /// <summary>
                /// The ID of the offline deployment.
                /// </summary>
                [NameInMap("buildDeployId")]
                [Validation(Required=false)]
                public string BuildDeployId { get; set; }

                /// <summary>
                /// The current online version number.
                /// </summary>
                [NameInMap("currentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                /// <summary>
                /// The name of the index table.
                /// </summary>
                [NameInMap("indexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// The index versions.
                /// </summary>
                [NameInMap("versions")]
                [Validation(Required=false)]
                public List<long?> Versions { get; set; }

            }

        }

    }

}
