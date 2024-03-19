// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteAlertContactGroupResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DeleteAlertContactGroupResponseBody> Body { get; set; }
        public class DeleteAlertContactGroupResponseBody : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            [NameInMap("contact_group_id")]
            [Validation(Required=false)]
            public string ContactGroupId { get; set; }

        }

    }

}
