// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstanceSpecsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The specifications of the instances.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInstanceSpecsResponseBodyResult> Result { get; set; }
        public class ListInstanceSpecsResponseBodyResult : TeaModel {
            /// <summary>
            /// The number of CPU cores.
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The maximum storage space of a searcher worker.
            /// </summary>
            [NameInMap("maxDisk")]
            [Validation(Required=false)]
            public int? MaxDisk { get; set; }

            /// <summary>
            /// The memory size. Unit: GB.
            /// </summary>
            [NameInMap("mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// The minimum storage space of a searcher worker.
            /// </summary>
            [NameInMap("minDisk")]
            [Validation(Required=false)]
            public int? MinDisk { get; set; }

        }

    }

}
