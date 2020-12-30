// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeBatchSlsDispatchStatusResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlsConfigStatusList")]
        [Validation(Required=false)]
        public List<DescribeBatchSlsDispatchStatusResponseBodySlsConfigStatusList> SlsConfigStatusList { get; set; }
        public class DescribeBatchSlsDispatchStatusResponseBodySlsConfigStatusList : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

    }

}
