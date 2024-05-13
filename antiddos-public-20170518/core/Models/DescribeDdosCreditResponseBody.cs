// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCreditResponseBody : TeaModel {
        /// <summary>
        /// The details of the security credit score of the current Alibaba Cloud account in the specified region.
        /// </summary>
        [NameInMap("DdosCredit")]
        [Validation(Required=false)]
        public DescribeDdosCreditResponseBodyDdosCredit DdosCredit { get; set; }
        public class DescribeDdosCreditResponseBodyDdosCredit : TeaModel {
            /// <summary>
            /// The time period after which blackhole filtering is automatically deactivated in the specified region. Unit: minutes.
            /// </summary>
            [NameInMap("BlackholeTime")]
            [Validation(Required=false)]
            public int? BlackholeTime { get; set; }

            /// <summary>
            /// The security credit score. The full score is **1000**.
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// The security credit level. Valid values:
            /// 
            /// *   **A**: outstanding
            /// *   **B**: excellent
            /// *   **C**: good
            /// *   **D**: average
            /// *   **E**: poor
            /// *   **F**: poorer
            /// </summary>
            [NameInMap("ScoreLevel")]
            [Validation(Required=false)]
            public string ScoreLevel { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
