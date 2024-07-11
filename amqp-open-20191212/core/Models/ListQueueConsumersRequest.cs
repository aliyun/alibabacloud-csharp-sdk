// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueueConsumersRequest : TeaModel {
        /// <summary>
        /// The ID of the ApsaraMQ for RabbitMQ instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The token that marks the end position of the previous returned page. To obtain the next batch of data, call the operation again by using the value of NextToken returned by the previous request. If you call this operation for the first time or want to query all results, set NextToken to an empty string.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of data entries to return. If you do not configure this parameter, the default value 1 is used.
        /// 
        /// Valid values: 1 to 100.
        /// </summary>
        [NameInMap("QueryCount")]
        [Validation(Required=false)]
        public int? QueryCount { get; set; }

        /// <summary>
        /// The name of the queue for which you want to query online consumers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

        /// <summary>
        /// The virtual host (vhost) name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
