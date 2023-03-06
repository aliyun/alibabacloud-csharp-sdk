// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetClusterDataInformationResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetClusterDataInformationResponseBodyResult Result { get; set; }
        public class GetClusterDataInformationResponseBodyResult : TeaModel {
            /// <summary>
            /// Whether it is connectable.
            /// </summary>
            [NameInMap("connectable")]
            [Validation(Required=false)]
            public bool? Connectable { get; set; }

            /// <summary>
            /// The metadata of the cluster.
            /// </summary>
            [NameInMap("metaInfo")]
            [Validation(Required=false)]
            public GetClusterDataInformationResponseBodyResultMetaInfo MetaInfo { get; set; }
            public class GetClusterDataInformationResponseBodyResultMetaInfo : TeaModel {
                /// <summary>
                /// The fields in the Mapping for the index.
                /// </summary>
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<string> Fields { get; set; }

                /// <summary>
                /// The index list of the cluster.
                /// </summary>
                [NameInMap("indices")]
                [Validation(Required=false)]
                public List<string> Indices { get; set; }

                /// <summary>
                /// The Mapping configuration of the cluster.
                /// </summary>
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                /// <summary>
                /// The Settings of the cluster.
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                /// <summary>
                /// Specifies the type of the index.
                /// </summary>
                [NameInMap("typeName")]
                [Validation(Required=false)]
                public List<string> TypeName { get; set; }

            }

        }

    }

}
