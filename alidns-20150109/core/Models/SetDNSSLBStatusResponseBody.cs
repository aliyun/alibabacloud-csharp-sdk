// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDNSSLBStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RecordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        [NameInMap("Open")]
        [Validation(Required=false)]
        public bool? Open { get; set; }

    }

}
