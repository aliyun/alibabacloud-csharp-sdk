// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DeleteQueueRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The queue name.
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// The vhost name.
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
