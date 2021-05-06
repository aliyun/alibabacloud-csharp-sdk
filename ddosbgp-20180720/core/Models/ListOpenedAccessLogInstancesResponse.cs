// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListOpenedAccessLogInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("SlsConfigStatus")]
        [Validation(Required=true)]
        public List<ListOpenedAccessLogInstancesResponseSlsConfigStatus> SlsConfigStatus { get; set; }
        public class ListOpenedAccessLogInstancesResponseSlsConfigStatus : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=true)]
            public bool? Enable { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

        }

    }

}
