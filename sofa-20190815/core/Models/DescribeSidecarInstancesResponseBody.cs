// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeSidecarInstancesResponseBody : TeaModel {
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSidecarInstancesResponseBodyItems> Items { get; set; }
        public class DescribeSidecarInstancesResponseBodyItems : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            [NameInMap("AppServiceName")]
            [Validation(Required=false)]
            public string AppServiceName { get; set; }

            [NameInMap("SidecarVersion")]
            [Validation(Required=false)]
            public string SidecarVersion { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("SidecarStatus")]
            [Validation(Required=false)]
            public string SidecarStatus { get; set; }

            [NameInMap("SidecarType")]
            [Validation(Required=false)]
            public string SidecarType { get; set; }

            [NameInMap("Clustername")]
            [Validation(Required=false)]
            public string Clustername { get; set; }

            [NameInMap("PodStatus")]
            [Validation(Required=false)]
            public string PodStatus { get; set; }

            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
