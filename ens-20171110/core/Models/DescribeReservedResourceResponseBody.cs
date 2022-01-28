// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeReservedResourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeReservedResourceResponseBodyImages Images { get; set; }
        public class DescribeReservedResourceResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeReservedResourceResponseBodyImagesImage> Image { get; set; }
            public class DescribeReservedResourceResponseBodyImagesImage : TeaModel {
                public string ImageId { get; set; }
                public string ImageName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeReservedResourceResponseBodySupportResources SupportResources { get; set; }
        public class DescribeReservedResourceResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeReservedResourceResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeReservedResourceResponseBodySupportResourcesSupportResource : TeaModel {
                public DescribeReservedResourceResponseBodySupportResourcesSupportResourceDataDiskSizes DataDiskSizes { get; set; }
                public class DescribeReservedResourceResponseBodySupportResourcesSupportResourceDataDiskSizes : TeaModel {
                    [NameInMap("DataDiskSize")]
                    [Validation(Required=false)]
                    public List<string> DataDiskSize { get; set; }

                }
                public string EnsRegionId { get; set; }
                public string InstanceSpec { get; set; }
                public string SupportResourcesCount { get; set; }
                public DescribeReservedResourceResponseBodySupportResourcesSupportResourceSystemDiskSizes SystemDiskSizes { get; set; }
                public class DescribeReservedResourceResponseBodySupportResourcesSupportResourceSystemDiskSizes : TeaModel {
                    [NameInMap("SystemDiskSize")]
                    [Validation(Required=false)]
                    public List<string> SystemDiskSize { get; set; }

                }
            }
        };

    }

}
