// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterVideoResourcesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("VideoResources")]
        [Validation(Required=true)]
        public DescribeCasterVideoResourcesResponseVideoResources VideoResources { get; set; }
        public class DescribeCasterVideoResourcesResponseVideoResources : TeaModel {
            [NameInMap("VideoResource")]
            [Validation(Required=true)]
            public List<DescribeCasterVideoResourcesResponseVideoResourcesVideoResource> VideoResource { get; set; }
            public class DescribeCasterVideoResourcesResponseVideoResourcesVideoResource : TeaModel {
                public string MaterialId { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string LocationId { get; set; }
                public string LiveStreamUrl { get; set; }
                public int? RepeatNum { get; set; }
                public string VodUrl { get; set; }
                public int? BeginOffset { get; set; }
                public int? EndOffset { get; set; }
                public int? PtsCallbackInterval { get; set; }
            }
        };

    }

}
