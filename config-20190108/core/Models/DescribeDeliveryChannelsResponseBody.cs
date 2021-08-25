// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeDeliveryChannelsResponseBody : TeaModel {
        [NameInMap("DeliveryChannels")]
        [Validation(Required=false)]
        public List<DescribeDeliveryChannelsResponseBodyDeliveryChannels> DeliveryChannels { get; set; }
        public class DescribeDeliveryChannelsResponseBodyDeliveryChannels : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("DeliveryChannelName")]
            [Validation(Required=false)]
            public string DeliveryChannelName { get; set; }

            [NameInMap("DeliveryChannelId")]
            [Validation(Required=false)]
            public string DeliveryChannelId { get; set; }

            [NameInMap("DeliveryChannelType")]
            [Validation(Required=false)]
            public string DeliveryChannelType { get; set; }

            [NameInMap("DeliveryChannelAssumeRoleArn")]
            [Validation(Required=false)]
            public string DeliveryChannelAssumeRoleArn { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DeliveryChannelCondition")]
            [Validation(Required=false)]
            public string DeliveryChannelCondition { get; set; }

            [NameInMap("DeliveryChannelTargetArn")]
            [Validation(Required=false)]
            public string DeliveryChannelTargetArn { get; set; }

            [NameInMap("ConfigurationSnapshot")]
            [Validation(Required=false)]
            public bool? ConfigurationSnapshot { get; set; }

            [NameInMap("ConfigurationItemChangeNotification")]
            [Validation(Required=false)]
            public bool? ConfigurationItemChangeNotification { get; set; }

            [NameInMap("NonCompliantNotification")]
            [Validation(Required=false)]
            public bool? NonCompliantNotification { get; set; }

            [NameInMap("OversizedDataOSSTargetArn")]
            [Validation(Required=false)]
            public string OversizedDataOSSTargetArn { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
