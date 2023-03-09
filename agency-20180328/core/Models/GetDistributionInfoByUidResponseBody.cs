// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180328.Models
{
    public class GetDistributionInfoByUidResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FxDistributionInfoVO")]
        [Validation(Required=false)]
        public GetDistributionInfoByUidResponseBodyFxDistributionInfoVO FxDistributionInfoVO { get; set; }
        public class GetDistributionInfoByUidResponseBodyFxDistributionInfoVO : TeaModel {
            /// <summary>
            /// bizType
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("DistributionRebateType")]
            [Validation(Required=false)]
            public int? DistributionRebateType { get; set; }

            /// <summary>
            /// level
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            /// <summary>
            /// uid
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
