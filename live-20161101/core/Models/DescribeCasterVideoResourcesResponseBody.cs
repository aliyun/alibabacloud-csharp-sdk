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
                [NameInMap("BeginOffset")]
                [Validation(Required=false)]
                public int? BeginOffset { get; set; }

                [NameInMap("EndOffset")]
                [Validation(Required=false)]
                public int? EndOffset { get; set; }

                [NameInMap("FlvUrl")]
                [Validation(Required=false)]
                public string FlvUrl { get; set; }

                [NameInMap("LiveStreamUrl")]
                [Validation(Required=false)]
                public string LiveStreamUrl { get; set; }

                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public string LocationId { get; set; }

                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

                [NameInMap("PtsCallbackInterval")]
                [Validation(Required=false)]
                public int? PtsCallbackInterval { get; set; }

                [NameInMap("RepeatNum")]
                [Validation(Required=false)]
                public int? RepeatNum { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("VodUrl")]
                [Validation(Required=false)]
                public string VodUrl { get; set; }

            }

        }

    }

}
