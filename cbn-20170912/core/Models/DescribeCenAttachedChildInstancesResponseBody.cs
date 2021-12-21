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
                public string CenId { get; set; }
                public string ChildInstanceAttachTime { get; set; }
                public string ChildInstanceId { get; set; }
                public long? ChildInstanceOwnerId { get; set; }
                public string ChildInstanceRegionId { get; set; }
                public string ChildInstanceType { get; set; }
                public string Status { get; set; }
            }
        };

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
