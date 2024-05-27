// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class BatchKillProcessListResponseBody : TeaModel {
        /// <summary>
        /// The array of the return result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BatchKillProcessListResponseBodyData> Data { get; set; }
        public class BatchKillProcessListResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the calling is successful.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
