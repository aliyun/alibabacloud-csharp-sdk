// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterVideoResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("VideoResources")]
        [Validation(Required=false)]
        public DescribeCasterVideoResourcesResponseBodyVideoResources VideoResources { get; set; }
        public class DescribeCasterVideoResourcesResponseBodyVideoResources : TeaModel {
            [NameInMap("VideoResource")]
            [Validation(Required=false)]
            public List<DescribeCasterVideoResourcesResponseBodyVideoResourcesVideoResource> VideoResource { get; set; }
            public class DescribeCasterVideoResourcesResponseBodyVideoResourcesVideoResource : TeaModel {
                public int? EndOffset { get; set; }
                public int? BeginOffset { get; set; }
                public int? PtsCallbackInterval { get; set; }
                public string MaterialId { get; set; }
                public string LocationId { get; set; }
                public string LiveStreamUrl { get; set; }
                public string VodUrl { get; set; }
                public string ResourceId { get; set; }
                public int? RepeatNum { get; set; }
                public string ResourceName { get; set; }
            }
        };

    }

}
