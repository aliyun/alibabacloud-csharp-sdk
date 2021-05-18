// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class StartCallV2Request : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public int? CallerType { get; set; }

        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

    }

}
