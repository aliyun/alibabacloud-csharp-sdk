// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListTablesResponseBodyResult> Result { get; set; }
        public class ListTablesResponseBodyResult : TeaModel {
            /// <summary>
            /// The state of the index table. Valid values: NEW, PUBLISH, IN_USE, NOT_USE, STOP_USE, RESTORE_USE, and FAIL. After an index is created in an OpenSearch Retrieval Engine Edition instance, the index enters the IN_USE state. If the first full index fails to be created in an OpenSearch Vector Search Edition instance of the new version, the index is in the FAIL state.
            /// </summary>
            [NameInMap("indexStatus")]
            [Validation(Required=false)]
            public string IndexStatus { get; set; }

            /// <summary>
            /// The index name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The state of the index table. Valid values: NEW, PUBLISH, IN_USE, NOT_USE, STOP_USE, RESTORE_USE, and FAIL. After an index is created in an OpenSearch Retrieval Engine Edition instance, the index enters the IN_USE state. If the first full index fails to be created in an OpenSearch Vector Search Edition instance of the new version, the index is in the FAIL state.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
