// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeDeliveryChannelsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DeliveryChannels")]
        [Validation(Required=true)]
        public List<DescribeDeliveryChannelsResponseDeliveryChannels> DeliveryChannels { get; set; }
        public class DescribeDeliveryChannelsResponseDeliveryChannels : TeaModel {
            [NameInMap("DeliveryChannelId")]
            [Validation(Required=true)]
            public string DeliveryChannelId { get; set; }

            [NameInMap("DeliveryChannelName")]
            [Validation(Required=true)]
            public string DeliveryChannelName { get; set; }

            [NameInMap("DeliveryChannelType")]
            [Validation(Required=true)]
            public string DeliveryChannelType { get; set; }

            [NameInMap("DeliveryChannelTargetArn")]
            [Validation(Required=true)]
            public string DeliveryChannelTargetArn { get; set; }

            [NameInMap("DeliveryChannelAssumeRoleArn")]
            [Validation(Required=true)]
            public string DeliveryChannelAssumeRoleArn { get; set; }

            [NameInMap("DeliveryChannelCondition")]
            [Validation(Required=true)]
            public string DeliveryChannelCondition { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }

        }

    }

}
