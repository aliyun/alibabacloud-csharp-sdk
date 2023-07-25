// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnFullDomainsBlockIPHistoryResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// The value of Code is not 0 in the following scenarios:
        /// 
        /// *   The format of the IP address is invalid.
        /// *   The format of the time is invalid.
        /// *   Other abnormal scenarios
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The description of the status returned.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The result of the operation.
        /// </summary>
        [NameInMap("IPBlockInfo")]
        [Validation(Required=false)]
        public List<DescribeDcdnFullDomainsBlockIPHistoryResponseBodyIPBlockInfo> IPBlockInfo { get; set; }
        public class DescribeDcdnFullDomainsBlockIPHistoryResponseBodyIPBlockInfo : TeaModel {
            /// <summary>
            /// The blocked IP address or CIDR block.
            /// </summary>
            [NameInMap("BlockIP")]
            [Validation(Required=false)]
            public string BlockIP { get; set; }

            /// <summary>
            /// The delivery time.
            /// </summary>
            [NameInMap("DeliverTime")]
            [Validation(Required=false)]
            public string DeliverTime { get; set; }

            /// <summary>
            /// The delivery status.
            /// 
            /// *   Success
            /// *   Failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
