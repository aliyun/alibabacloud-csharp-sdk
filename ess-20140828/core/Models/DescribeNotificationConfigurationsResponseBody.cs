// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeNotificationConfigurationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NotificationConfigurationModels")]
        [Validation(Required=false)]
        public DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels NotificationConfigurationModels { get; set; }
        public class DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels : TeaModel {
            [NameInMap("NotificationConfigurationModel")]
            [Validation(Required=false)]
            public List<DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModelsNotificationConfigurationModel> NotificationConfigurationModel { get; set; }
            public class DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModelsNotificationConfigurationModel : TeaModel {
                public string NotificationArn { get; set; }
                public string ScalingGroupId { get; set; }
                public DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModelsNotificationConfigurationModelNotificationTypes NotificationTypes { get; set; }
                public class DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModelsNotificationConfigurationModelNotificationTypes : TeaModel {
                    [NameInMap("NotificationType")]
                    [Validation(Required=false)]
                    public List<string> NotificationType { get; set; }

                }
            }
        };

    }

}
