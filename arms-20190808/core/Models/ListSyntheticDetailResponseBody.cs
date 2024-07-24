// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSyntheticDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSyntheticDetailResponseBodyData Data { get; set; }
        public class ListSyntheticDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The list of results.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Items { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TaskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
