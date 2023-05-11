// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DetachDestinationRequest : TeaModel {
        /// <summary>
        /// The ID of the data destination. You can call the [ListDestination](~~433025~~) operation to query data destinations and obtain the ID of the **data destination**.
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public long? DestinationId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or ID is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the parser. You can call the [ListParser](~~444814~~) operation to query parsers and obtain the ID of the **parser**.
        /// </summary>
        [NameInMap("ParserId")]
        [Validation(Required=false)]
        public long? ParserId { get; set; }

    }

}
