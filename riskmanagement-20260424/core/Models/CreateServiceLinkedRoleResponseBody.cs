// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateServiceLinkedRoleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateServiceLinkedRoleResponseBodyData Data { get; set; }
        public class CreateServiceLinkedRoleResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public CreateServiceLinkedRoleResponseBodyDataBody Body { get; set; }
            public class CreateServiceLinkedRoleResponseBodyDataBody : TeaModel {
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }

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
