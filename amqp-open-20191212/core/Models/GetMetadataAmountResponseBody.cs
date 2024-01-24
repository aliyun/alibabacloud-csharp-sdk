// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class GetMetadataAmountResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetadataAmountResponseBodyData Data { get; set; }
        public class GetMetadataAmountResponseBodyData : TeaModel {
            /// <summary>
            /// The number of created exchanges on the ApsaraMQ for RabbitMQ instance.
            /// </summary>
            [NameInMap("CurrentExchanges")]
            [Validation(Required=false)]
            public int? CurrentExchanges { get; set; }

            /// <summary>
            /// The number of created queues on the ApsaraMQ for RabbitMQ instance.
            /// </summary>
            [NameInMap("CurrentQueues")]
            [Validation(Required=false)]
            public int? CurrentQueues { get; set; }

            /// <summary>
            /// The number of created vhosts on the ApsaraMQ for RabbitMQ instance.
            /// </summary>
            [NameInMap("CurrentVirtualHosts")]
            [Validation(Required=false)]
            public int? CurrentVirtualHosts { get; set; }

            /// <summary>
            /// The maximum number of exchanges that can be created on the ApsaraMQ for RabbitMQ instance.
            /// </summary>
            [NameInMap("MaxExchanges")]
            [Validation(Required=false)]
            public int? MaxExchanges { get; set; }

            /// <summary>
            /// The maximum number of queues that can be created on the ApsaraMQ for RabbitMQ instance.
            /// </summary>
            [NameInMap("MaxQueues")]
            [Validation(Required=false)]
            public int? MaxQueues { get; set; }

            /// <summary>
            /// The maximum number of vhosts that can be created on the ApsaraMQ for RabbitMQ instance.
            /// </summary>
            [NameInMap("MaxVirtualHosts")]
            [Validation(Required=false)]
            public int? MaxVirtualHosts { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
