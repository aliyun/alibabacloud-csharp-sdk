// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeADInfoResponseBody : TeaModel {
        [NameInMap("ADDNS")]
        [Validation(Required=false)]
        public string ADDNS { get; set; }

        [NameInMap("ADServerIpAddress")]
        [Validation(Required=false)]
        public string ADServerIpAddress { get; set; }

        [NameInMap("ADStatus")]
        [Validation(Required=false)]
        public string ADStatus { get; set; }

        [NameInMap("AbnormalReason")]
        [Validation(Required=false)]
        public string AbnormalReason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
