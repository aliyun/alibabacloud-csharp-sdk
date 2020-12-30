// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeFlexAccConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FlexAccConfig")]
        [Validation(Required=false)]
        public DescribeFlexAccConfigResponseBodyFlexAccConfig FlexAccConfig { get; set; }
        public class DescribeFlexAccConfigResponseBodyFlexAccConfig : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("TcpPorts")]
            [Validation(Required=false)]
            public string TcpPorts { get; set; }
            [NameInMap("UdpPorts")]
            [Validation(Required=false)]
            public string UdpPorts { get; set; }
        };

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
