// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDataSourceResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of information about the data source
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDataSourceResponseBodyResult Result { get; set; }
        public class GetDataSourceResponseBodyResult : TeaModel {
            /// <summary>
            /// The data center where the data source is deployed in offline mode
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The list of index information
            /// </summary>
            [NameInMap("indexes")]
            [Validation(Required=false)]
            public List<string> Indexes { get; set; }

            /// <summary>
            /// The time when an index for full data was last built
            /// </summary>
            [NameInMap("lastFulTime")]
            [Validation(Required=false)]
            public long? LastFulTime { get; set; }

            /// <summary>
            /// The name of the data source
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The state of the data source
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the data source
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
