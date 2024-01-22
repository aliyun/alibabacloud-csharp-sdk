// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class InstanceExecAuthorizationOutput : TeaModel {
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
