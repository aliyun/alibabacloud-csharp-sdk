// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeReservedResourceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Images")]
        [Validation(Required=true)]
        public DescribeReservedResourceResponseImages Images { get; set; }
        public class DescribeReservedResourceResponseImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=true)]
            public List<DescribeReservedResourceResponseImagesImage> Image { get; set; }
            public class DescribeReservedResourceResponseImagesImage : TeaModel {
                public string ImageId { get; set; }
                public string ImageName { get; set; }
            }
        };

        [NameInMap("SupportResources")]
        [Validation(Required=true)]
        public DescribeReservedResourceResponseSupportResources SupportResources { get; set; }
        public class DescribeReservedResourceResponseSupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=true)]
            public List<DescribeReservedResourceResponseSupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeReservedResourceResponseSupportResourcesSupportResource : TeaModel {
                public string EnsRegionId { get; set; }
                public string SupportResourcesCount { get; set; }
                public string InstanceSpec { get; set; }
                public DescribeReservedResourceResponseSupportResourcesSupportResourceSystemDiskSizes SystemDiskSizes { get; set; }
                public class DescribeReservedResourceResponseSupportResourcesSupportResourceSystemDiskSizes : TeaModel {
                    /// <summary>
                    /// SystemDiskSize
                    /// </summary>
                    [NameInMap("SystemDiskSize")]
                    [Validation(Required=true)]
                    public List<string> SystemDiskSize { get; set; }

                }
                public DescribeReservedResourceResponseSupportResourcesSupportResourceDataDiskSizes DataDiskSizes { get; set; }
                public class DescribeReservedResourceResponseSupportResourcesSupportResourceDataDiskSizes : TeaModel {
                    /// <summary>
                    /// DataDiskSize
                    /// </summary>
                    [NameInMap("DataDiskSize")]
                    [Validation(Required=true)]
                    public List<string> DataDiskSize { get; set; }

                }
            }
        };

    }

}
