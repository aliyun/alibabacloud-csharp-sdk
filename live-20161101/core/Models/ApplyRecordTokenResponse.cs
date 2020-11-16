// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ApplyRecordTokenResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=true)]
        public string SecurityToken { get; set; }

        [NameInMap("AccessKeySecret")]
        [Validation(Required=true)]
        public string AccessKeySecret { get; set; }

        [NameInMap("AccessKeyId")]
        [Validation(Required=true)]
        public string AccessKeyId { get; set; }

        [NameInMap("Expiration")]
        [Validation(Required=true)]
        public string Expiration { get; set; }

    }

}
