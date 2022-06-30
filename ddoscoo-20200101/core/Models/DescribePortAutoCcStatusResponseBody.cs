// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortAutoCcStatusResponseBody : TeaModel {
        [NameInMap("PortAutoCcStatus")]
        [Validation(Required=false)]
        public List<DescribePortAutoCcStatusResponseBodyPortAutoCcStatus> PortAutoCcStatus { get; set; }
        public class DescribePortAutoCcStatusResponseBodyPortAutoCcStatus : TeaModel {
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Switch")]
            [Validation(Required=false)]
            public string Switch { get; set; }

            [NameInMap("WebMode")]
            [Validation(Required=false)]
            public string WebMode { get; set; }

            [NameInMap("WebSwitch")]
            [Validation(Required=false)]
            public string WebSwitch { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
