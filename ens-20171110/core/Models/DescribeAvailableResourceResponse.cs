// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Images")]
        [Validation(Required=true)]
        public DescribeAvailableResourceResponseImages Images { get; set; }
        public class DescribeAvailableResourceResponseImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=true)]
            public List<DescribeAvailableResourceResponseImagesImage> Image { get; set; }
            public class DescribeAvailableResourceResponseImagesImage : TeaModel {
                public string ImageId { get; set; }
                public string ImageName { get; set; }
            }
        };

        [NameInMap("SupportResources")]
        [Validation(Required=true)]
        public DescribeAvailableResourceResponseSupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceResponseSupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=true)]
            public List<DescribeAvailableResourceResponseSupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceResponseSupportResourcesSupportResource : TeaModel {
                public string DataDiskSize { get; set; }
                public string EnsRegionId { get; set; }
                public string SupportResourcesCount { get; set; }
                public string InstanceSpec { get; set; }
                public string SystemDiskSize { get; set; }
            }
        };

    }

}
