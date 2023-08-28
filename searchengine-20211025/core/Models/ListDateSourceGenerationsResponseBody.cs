// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDateSourceGenerationsResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// List
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDateSourceGenerationsResponseBodyResult> Result { get; set; }
        public class ListDateSourceGenerationsResponseBodyResult : TeaModel {
            /// <summary>
            /// buildDeployId
            /// </summary>
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public int? BuildDeployId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("dataDumpRoot")]
            [Validation(Required=false)]
            public string DataDumpRoot { get; set; }

            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

            [NameInMap("partition")]
            [Validation(Required=false)]
            public Dictionary<string, int?> Partition { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
