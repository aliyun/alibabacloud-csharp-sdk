// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeAlertContactWithAlertSettingIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAlertContactWithAlertSettingIdResponseBodyData> Data { get; set; }
        public class DescribeAlertContactWithAlertSettingIdResponseBodyData : TeaModel {
            [NameInMap("contactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("contactType")]
            [Validation(Required=false)]
            public long? ContactType { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
