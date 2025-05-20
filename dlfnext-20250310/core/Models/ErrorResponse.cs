// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ErrorResponse : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
