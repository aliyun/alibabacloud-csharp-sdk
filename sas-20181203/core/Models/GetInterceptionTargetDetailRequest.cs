// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionTargetDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the network object.
        /// 
        /// > You can call the [ListInterceptionTargetPage](~~ListInterceptionTargetPage~~) operation to query the IDs of network objects.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public long? TargetId { get; set; }

    }

}
