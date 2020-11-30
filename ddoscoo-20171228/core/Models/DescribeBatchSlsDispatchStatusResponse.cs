// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeBatchSlsDispatchStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("SlsConfigStatusList")]
        [Validation(Required=true)]
        public List<DescribeBatchSlsDispatchStatusResponseSlsConfigStatusList> SlsConfigStatusList { get; set; }
        public class DescribeBatchSlsDispatchStatusResponseSlsConfigStatusList : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=true)]
            public bool? Enable { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=true)]
            public string Domain { get; set; }

        }

    }

}
