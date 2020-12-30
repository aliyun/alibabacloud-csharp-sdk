// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Teambition_aliyun20200226.Models
{
    public class ApplySmallMicroResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("raw")]
        [Validation(Required=false)]
        public bool? Raw { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public bool? Message { get; set; }

    }

}
