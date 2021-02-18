// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConnectionStatusResponseBody : TeaModel {
        [NameInMap("SourceConnectionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceConnectionStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DestinationConnectionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> DestinationConnectionStatus { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
