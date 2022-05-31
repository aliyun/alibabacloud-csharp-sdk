// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateConfigDeliveryChannelRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ConfigurationItemChangeNotification")]
        [Validation(Required=false)]
        public bool? ConfigurationItemChangeNotification { get; set; }

        [NameInMap("ConfigurationSnapshot")]
        [Validation(Required=false)]
        public bool? ConfigurationSnapshot { get; set; }

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

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("NonCompliantNotification")]
        [Validation(Required=false)]
        public bool? NonCompliantNotification { get; set; }

        [NameInMap("OversizedDataOSSTargetArn")]
        [Validation(Required=false)]
        public string OversizedDataOSSTargetArn { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
