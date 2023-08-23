// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeNotificationTypesResponseBody : TeaModel {
        [NameInMap("NotificationTypes")]
        [Validation(Required=false)]
        public List<string> NotificationTypes { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
