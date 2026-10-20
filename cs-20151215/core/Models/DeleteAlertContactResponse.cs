// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteAlertContactResponse : Darabonba.Model {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public DeleteAlertContactResponseBody Body { get; set; }
        public class DeleteAlertContactResponseBody : Darabonba.Model {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<DeleteAlertContactResponseBodyResult> Result { get; set; }
            public class DeleteAlertContactResponseBodyResult : Darabonba.Model {
                [NameInMap("status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("contact_id")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

            }

        }

    }

}

