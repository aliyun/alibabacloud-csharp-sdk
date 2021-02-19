// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeNotificationTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NotificationTypes")]
        [Validation(Required=false)]
        public DescribeNotificationTypesResponseBodyNotificationTypes NotificationTypes { get; set; }
        public class DescribeNotificationTypesResponseBodyNotificationTypes : TeaModel {
            [NameInMap("NotificationType")]
            [Validation(Required=false)]
            public List<string> NotificationType { get; set; }
        };

    }

}
