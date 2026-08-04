// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetCustomerInformationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerInformationResponseBodyData Data { get; set; }
        public class GetCustomerInformationResponseBodyData : TeaModel {
            [NameInMap("Biz")]
            [Validation(Required=false)]
            public string Biz { get; set; }

            [NameInMap("CustomerCategory")]
            [Validation(Required=false)]
            public string CustomerCategory { get; set; }

            [NameInMap("Website")]
            [Validation(Required=false)]
            public string Website { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
