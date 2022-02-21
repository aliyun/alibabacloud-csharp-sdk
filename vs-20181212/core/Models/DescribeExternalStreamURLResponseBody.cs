// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeExternalStreamURLResponseBody : TeaModel {
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TxId")]
        [Validation(Required=false)]
        public string TxId { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
