// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeUserFlowInfoResponseBody : TeaModel {
        [NameInMap("FlowInfo")]
        [Validation(Required=false)]
        public DescribeUserFlowInfoResponseBodyFlowInfo FlowInfo { get; set; }
        public class DescribeUserFlowInfoResponseBodyFlowInfo : TeaModel {
            [NameInMap("BizBandWidth")]
            [Validation(Required=false)]
            public long? BizBandWidth { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
