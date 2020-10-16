// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SyncDeviceTimeResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("NTPServer")]
        [Validation(Required=true)]
        public string NTPServer { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=true)]
        public string RetryInterval { get; set; }

        [NameInMap("SyncInterval")]
        [Validation(Required=true)]
        public string SyncInterval { get; set; }

        [NameInMap("TimeStamp")]
        [Validation(Required=true)]
        public string TimeStamp { get; set; }

    }

}
