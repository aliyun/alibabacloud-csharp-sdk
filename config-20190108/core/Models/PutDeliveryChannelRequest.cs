// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class PutDeliveryChannelRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeliveryChannelAssumeRoleArn")]
        [Validation(Required=false)]
        public string DeliveryChannelAssumeRoleArn { get; set; }

        [NameInMap("DeliveryChannelCondition")]
        [Validation(Required=false)]
        public string DeliveryChannelCondition { get; set; }

        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        [NameInMap("DeliveryChannelTargetArn")]
        [Validation(Required=false)]
        public string DeliveryChannelTargetArn { get; set; }

        [NameInMap("DeliveryChannelType")]
        [Validation(Required=false)]
        public string DeliveryChannelType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
