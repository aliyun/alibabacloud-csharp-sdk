// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class MakeCallRequest : TeaModel {
        [NameInMap("OuterAccountId")]
        [Validation(Required=false)]
        public string OuterAccountId { get; set; }

        [NameInMap("OuterAccountType")]
        [Validation(Required=false)]
        public string OuterAccountType { get; set; }

        [NameInMap("CommandCode")]
        [Validation(Required=false)]
        public string CommandCode { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

    }

}
