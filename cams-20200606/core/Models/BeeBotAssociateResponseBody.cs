// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotAssociateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeeBotAssociateResponseBodyData Data { get; set; }
        public class BeeBotAssociateResponseBodyData : TeaModel {
            [NameInMap("Associate")]
            [Validation(Required=false)]
            public List<BeeBotAssociateResponseBodyDataAssociate> Associate { get; set; }
            public class BeeBotAssociateResponseBodyDataAssociate : TeaModel {
                [NameInMap("Meta")]
                [Validation(Required=false)]
                public string Meta { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
