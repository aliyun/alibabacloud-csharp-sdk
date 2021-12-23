// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetEventCallbackRequest : TeaModel {
        [NameInMap("CallbackQueueName")]
        [Validation(Required=false)]
        public string CallbackQueueName { get; set; }

        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
