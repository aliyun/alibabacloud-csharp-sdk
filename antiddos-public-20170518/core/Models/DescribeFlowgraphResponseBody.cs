// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeFlowgraphResponseBody : TeaModel {
        [NameInMap("Flowgraphs")]
        [Validation(Required=false)]
        public List<DescribeFlowgraphResponseBodyFlowgraphs> Flowgraphs { get; set; }
        public class DescribeFlowgraphResponseBodyFlowgraphs : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("Bps")]
            [Validation(Required=false)]
            public long? Bps { get; set; }

            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
