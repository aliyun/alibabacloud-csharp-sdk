// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetVbrFlowTopNResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VirtualBorderRouterFlowlogTopN")]
        [Validation(Required=false)]
        public List<GetVbrFlowTopNResponseBodyVirtualBorderRouterFlowlogTopN> VirtualBorderRouterFlowlogTopN { get; set; }
        public class GetVbrFlowTopNResponseBodyVirtualBorderRouterFlowlogTopN : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            [NameInMap("CloudIp")]
            [Validation(Required=false)]
            public string CloudIp { get; set; }

            [NameInMap("CloudPort")]
            [Validation(Required=false)]
            public string CloudPort { get; set; }

            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("VirtualBorderRouterId")]
            [Validation(Required=false)]
            public string VirtualBorderRouterId { get; set; }

        }

    }

}
