// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateSkillFileCheckResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateSkillFileCheckResponseBody Body { get; set; }

    }

}
