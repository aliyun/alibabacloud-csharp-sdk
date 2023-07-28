// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class SendDryRunSystemEventRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to SendDryRunSystemEvent.
        /// </summary>
        [NameInMap("EventContent")]
        [Validation(Required=false)]
        public string EventContent { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The content of the system event.
        /// 
        /// >  The value of this parameter is a JSON object. We recommend that you include the `product`, `resourceId`, and `regionId` fields in the JSON object.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the system event.
        /// 
        /// >  For more information, see [DescribeSystemEventMetaList](~~114972~~).
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
