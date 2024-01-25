// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeAlertContactWithAlertSettingIdRequest : TeaModel {
        [NameInMap("AlertSettingId")]
        [Validation(Required=false)]
        public long? AlertSettingId { get; set; }

        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public long? ContactType { get; set; }

    }

}
