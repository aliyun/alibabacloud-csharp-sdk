// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeProjectsidpullrequestspullrequestidsubscribeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("SubscribableId")]
        [Validation(Required=false)]
        public long? SubscribableId { get; set; }

        [NameInMap("SubscribableType")]
        [Validation(Required=false)]
        public string SubscribableType { get; set; }

        [NameInMap("Subscribed")]
        [Validation(Required=false)]
        public bool? Subscribed { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
