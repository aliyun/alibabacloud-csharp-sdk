// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeReservedResourceResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. 0 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the image.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeReservedResourceResponseBodyImages Images { get; set; }
        public class DescribeReservedResourceResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeReservedResourceResponseBodyImagesImage> Image { get; set; }
            public class DescribeReservedResourceResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The name of the image.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources.
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeReservedResourceResponseBodySupportResources SupportResources { get; set; }
        public class DescribeReservedResourceResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeReservedResourceResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeReservedResourceResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// The sizes of data disks.
                /// </summary>
                [NameInMap("DataDiskSizes")]
                [Validation(Required=false)]
                public DescribeReservedResourceResponseBodySupportResourcesSupportResourceDataDiskSizes DataDiskSizes { get; set; }
                public class DescribeReservedResourceResponseBodySupportResourcesSupportResourceDataDiskSizes : TeaModel {
                    [NameInMap("DataDiskSize")]
                    [Validation(Required=false)]
                    public List<string> DataDiskSize { get; set; }

                }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The specifications of instances.
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// The number of resources that you can purchase.
                /// </summary>
                [NameInMap("SupportResourcesCount")]
                [Validation(Required=false)]
                public string SupportResourcesCount { get; set; }

                /// <summary>
                /// The sizes of system disks.
                /// </summary>
                [NameInMap("SystemDiskSizes")]
                [Validation(Required=false)]
                public DescribeReservedResourceResponseBodySupportResourcesSupportResourceSystemDiskSizes SystemDiskSizes { get; set; }
                public class DescribeReservedResourceResponseBodySupportResourcesSupportResourceSystemDiskSizes : TeaModel {
                    [NameInMap("SystemDiskSize")]
                    [Validation(Required=false)]
                    public List<string> SystemDiskSize { get; set; }

                }

            }

        }

    }

}
