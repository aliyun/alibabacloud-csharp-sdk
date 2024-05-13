// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCountResponseBody : TeaModel {
        /// <summary>
        /// The number of assets that are under DDoS attacks.
        /// </summary>
        [NameInMap("DdosCount")]
        [Validation(Required=false)]
        public DescribeDdosCountResponseBodyDdosCount DdosCount { get; set; }
        public class DescribeDdosCountResponseBodyDdosCount : TeaModel {
            /// <summary>
            /// The number of assets for which blackhole filtering is triggered.
            /// </summary>
            [NameInMap("BlackholeCount")]
            [Validation(Required=false)]
            public int? BlackholeCount { get; set; }

            /// <summary>
            /// The number of assets for which traffic scrubbing is triggered.
            /// </summary>
            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public int? DefenseCount { get; set; }

            /// <summary>
            /// The total number of assets.
            /// </summary>
            [NameInMap("InstacenCount")]
            [Validation(Required=false)]
            public int? InstacenCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
