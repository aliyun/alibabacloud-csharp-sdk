// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstancesResponseBody : TeaModel {
        [NameInMap("ChildInstances")]
        [Validation(Required=false)]
        public DescribeCenAttachedChildInstancesResponseBodyChildInstances ChildInstances { get; set; }
        public class DescribeCenAttachedChildInstancesResponseBodyChildInstances : TeaModel {
            [NameInMap("ChildInstance")]
            [Validation(Required=false)]
            public List<DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance> ChildInstance { get; set; }
            public class DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance : TeaModel {
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("ChildInstanceAttachTime")]
                [Validation(Required=false)]
                public string ChildInstanceAttachTime { get; set; }

                [NameInMap("ChildInstanceId")]
                [Validation(Required=false)]
                public string ChildInstanceId { get; set; }

                [NameInMap("ChildInstanceOwnerId")]
                [Validation(Required=false)]
                public long? ChildInstanceOwnerId { get; set; }

                [NameInMap("ChildInstanceRegionId")]
                [Validation(Required=false)]
                public string ChildInstanceRegionId { get; set; }

                [NameInMap("ChildInstanceType")]
                [Validation(Required=false)]
                public string ChildInstanceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
