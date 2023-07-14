// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDestinationRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// The actions of forwarding data to data destinations. Data is processed by using a parser script before the data is forwarded. Valid values:
        /// 
        /// *   **REPUBLISH**: forwards topic data to an IoT Platform communication topic.
        /// *   **AMQP**: forwards topic data to an Advanced Message Queuing Protocol (AMQP) consumer group.
        /// *   **DATAHUB**: forwards topic data to Alibaba Cloud DataHub for stream data processing.
        /// *   **ONS**: forwards topic data to Message Queue for Apache RocketMQ for message distribution.
        /// *   **MNS**: forwards topic data to Message Service (MNS) for message transmission.
        /// *   **FC**: forwards topic data to Function Compute for event computing.
        /// *   **OTS**: forwards topic data to Tablestore for NoSQL data storage.
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
