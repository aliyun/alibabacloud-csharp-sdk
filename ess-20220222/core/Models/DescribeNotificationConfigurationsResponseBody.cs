// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeNotificationConfigurationsResponseBody : TeaModel {
        [NameInMap("NotificationConfigurationModels")]
        [Validation(Required=false)]
        public List<DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels> NotificationConfigurationModels { get; set; }
        public class DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels : TeaModel {
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            [NameInMap("NotificationTypes")]
            [Validation(Required=false)]
            public List<string> NotificationTypes { get; set; }

            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
