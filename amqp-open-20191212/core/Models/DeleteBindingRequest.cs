// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DeleteBindingRequest : TeaModel {
        /// <summary>
        /// The binding key.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BindingKey")]
        [Validation(Required=false)]
        public string BindingKey { get; set; }

        /// <summary>
        /// The type of the object that you want to unbind from the source exchange. Valid values:
        /// 
        /// *   **QUEUE**
        /// *   **EXCHANGE**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BindingType")]
        [Validation(Required=false)]
        public string BindingType { get; set; }

        /// <summary>
        /// The name of the object that you want to unbind from the source exchange.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationName")]
        [Validation(Required=false)]
        public string DestinationName { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the source exchange.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceExchange")]
        [Validation(Required=false)]
        public string SourceExchange { get; set; }

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
