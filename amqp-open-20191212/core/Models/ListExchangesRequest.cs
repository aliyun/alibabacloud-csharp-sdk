// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListExchangesRequest : TeaModel {
        /// <summary>
        /// The ID of the ApsaraMQ for RabbitMQ instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Valid values: **1 to 100**
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If you call this operation for the first time or a next query is not required, leave this parameter empty.
        /// *   If a next query is to be sent, set the value to the value of `NextToken` that is returned from the previous request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The vhost name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
