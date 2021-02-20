// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyImages Images { get; set; }
        public class DescribeAvailableResourceResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyImagesImage> Image { get; set; }
            public class DescribeAvailableResourceResponseBodyImagesImage : TeaModel {
                public string ImageId { get; set; }
                public string ImageName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodySupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceResponseBodySupportResourcesSupportResource : TeaModel {
                public string DataDiskSize { get; set; }
                public string EnsRegionId { get; set; }
                public string InstanceSpec { get; set; }
                public string SupportResourcesCount { get; set; }
                public string SystemDiskSize { get; set; }
            }
        };

    }

}
