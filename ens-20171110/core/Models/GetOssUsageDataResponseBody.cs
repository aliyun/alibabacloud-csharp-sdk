// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssUsageDataResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of usage data.
        /// </summary>
        [NameInMap("UsageList")]
        [Validation(Required=false)]
        public List<GetOssUsageDataResponseBodyUsageList> UsageList { get; set; }
        public class GetOssUsageDataResponseBodyUsageList : TeaModel {
            /// <summary>
            /// The inbound bandwidth over the intranet. Unit: bit/s.
            /// </summary>
            [NameInMap("LanRxBw")]
            [Validation(Required=false)]
            public long? LanRxBw { get; set; }

            /// <summary>
            /// The outbound bandwidth over the intranet. Unit: bit/s.
            /// </summary>
            [NameInMap("LanTxBw")]
            [Validation(Required=false)]
            public long? LanTxBw { get; set; }

            /// <summary>
            /// The number of time point within a day.
            /// </summary>
            [NameInMap("Point")]
            [Validation(Required=false)]
            public long? Point { get; set; }

            /// <summary>
            /// The point in time, in UTC. Format: 2010-01-21T09:50:23Z.
            /// </summary>
            [NameInMap("PointTs")]
            [Validation(Required=false)]
            public string PointTs { get; set; }

            /// <summary>
            /// The storage usage. Unit: bytes.
            /// </summary>
            [NameInMap("StorageUsageByte")]
            [Validation(Required=false)]
            public long? StorageUsageByte { get; set; }

            /// <summary>
            /// The outbound bandwidth over the intranet. Unit: bit/s.
            /// </summary>
            [NameInMap("WanRxBw")]
            [Validation(Required=false)]
            public long? WanRxBw { get; set; }

            /// <summary>
            /// The outbound bandwidth over the Internet. Unit: bit/s.
            /// </summary>
            [NameInMap("WanTxBw")]
            [Validation(Required=false)]
            public long? WanTxBw { get; set; }

        }

    }

}
