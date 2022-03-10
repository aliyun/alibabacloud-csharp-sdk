// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListPortalMenuAuthorizationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPortalMenuAuthorizationResponseBodyResult> Result { get; set; }
        public class ListPortalMenuAuthorizationResponseBodyResult : TeaModel {
            [NameInMap("MenuId")]
            [Validation(Required=false)]
            public string MenuId { get; set; }

            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<ListPortalMenuAuthorizationResponseBodyResultReceivers> Receivers { get; set; }
            public class ListPortalMenuAuthorizationResponseBodyResultReceivers : TeaModel {
                [NameInMap("ReceiverId")]
                [Validation(Required=false)]
                public string ReceiverId { get; set; }

                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public int? ReceiverType { get; set; }

            }

            [NameInMap("ShowOnlyWithAccess")]
            [Validation(Required=false)]
            public bool? ShowOnlyWithAccess { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
