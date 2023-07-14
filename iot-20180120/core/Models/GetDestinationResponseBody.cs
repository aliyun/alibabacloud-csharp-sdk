// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDestinationResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the data destination.
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public GetDestinationResponseBodyDestination Destination { get; set; }
        public class GetDestinationResponseBodyDestination : TeaModel {
            /// <summary>
            /// The configuration data of the data destination.
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            /// <summary>
            /// The ID of the data destination.
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// Indicates whether the data destination is configured to receive error operation data. Error operation data is data that failed to be forwarded for two consecutive times.
            /// 
            /// *   **true**: The data destination is configured to receive error operation data.
            /// *   **false**: The data destination is configured to receive regular data instead of error operation data.
            /// 
            /// Default value: **false**.
            /// </summary>
            [NameInMap("IsFailover")]
            [Validation(Required=false)]
            public bool? IsFailover { get; set; }

            /// <summary>
            /// The name of the data destination.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The operation that is performed on the data of the data destination.
            /// 
            /// *   **REPUBLISH**: forwards topic data that is processed by a parser script to an IoT Platform communication topic.
            /// *   **AMQP**: forwards topic data that is processed by a parser script to an Advanced Message Queuing Protocol (AMQP) consumer group.
            /// *   **DATAHUB**: forwards topic data to Alibaba Cloud DataHub for stream data processing.
            /// *   **ONS**: forwards topic data that is processed by a parser script to Message Queue for Apache RocketMQ for message distribution.
            /// *   **MNS**: forwards topic data to Message Service (MNS) for message transmission.
            /// *   **FC**: forwards topic data to Function Compute for event computing.
            /// *   **OTS**: forwards topic data to Tablestore for NoSQL data storage.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The time when the data destination was created. The time is displayed in UTC. Format: `yyyy-MM-dd\"T\"HH:mm:ss.SSS\"Z\"`.
            /// </summary>
            [NameInMap("UtcCreated")]
            [Validation(Required=false)]
            public string UtcCreated { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
