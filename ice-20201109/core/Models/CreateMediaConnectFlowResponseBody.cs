// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateMediaConnectFlowResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateMediaConnectFlowResponseBodyContent Content { get; set; }
        public class CreateMediaConnectFlowResponseBodyContent : TeaModel {
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
