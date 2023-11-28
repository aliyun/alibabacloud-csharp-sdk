// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAvailableEsInstanceIdsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAvailableEsInstanceIdsResponseBodyResult> Result { get; set; }
        public class ListAvailableEsInstanceIdsResponseBodyResult : TeaModel {
            /// <summary>
            /// The name of the Elasticsearch cluster.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The address that is used to access the Elasticsearch cluster over the Internet.
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The ID of the Elasticsearch cluster.
            /// </summary>
            [NameInMap("esInstanceId")]
            [Validation(Required=false)]
            public string EsInstanceId { get; set; }

            /// <summary>
            /// The address that is used to access the Kibana console of the Elasticsearch cluster over the Internet.
            /// </summary>
            [NameInMap("kibanaEndpoint")]
            [Validation(Required=false)]
            public string KibanaEndpoint { get; set; }

        }

    }

}
