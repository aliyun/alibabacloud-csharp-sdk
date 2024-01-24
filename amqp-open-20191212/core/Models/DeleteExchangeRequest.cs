// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DeleteExchangeRequest : TeaModel {
        /// <summary>
        /// The name of the exchange that you want to delete.
        /// </summary>
        [NameInMap("ExchangeName")]
        [Validation(Required=false)]
        public string ExchangeName { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for RabbitMQ instance whose exchange you want to delete.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The vhost to which the exchange that you want to delete belongs.
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
