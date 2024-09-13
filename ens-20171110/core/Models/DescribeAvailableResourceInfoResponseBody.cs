// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the image.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeAvailableResourceInfoResponseBodyImages Images { get; set; }
        public class DescribeAvailableResourceInfoResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceInfoResponseBodyImagesImage> Image { get; set; }
            public class DescribeAvailableResourceInfoResponseBodyImagesImage : TeaModel {
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

                /// <summary>
                /// The size of the image. Unit: GB.
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public int? ImageSize { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The specifications of resources that you can purchase.
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceInfoResponseBodySupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceInfoResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// Bandwidth billing method.
                /// </summary>
                [NameInMap("BandwidthTypes")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceBandwidthTypes BandwidthTypes { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceBandwidthTypes : TeaModel {
                    [NameInMap("BandwidthType")]
                    [Validation(Required=false)]
                    public List<string> BandwidthType { get; set; }

                }

                /// <summary>
                /// The maximum capacity of a data disk. Unit: GB.
                /// </summary>
                [NameInMap("DataDiskMaxSize")]
                [Validation(Required=false)]
                public int? DataDiskMaxSize { get; set; }

                /// <summary>
                /// The minimum data disk size. Unit: GiB.
                /// </summary>
                [NameInMap("DataDiskMinSize")]
                [Validation(Required=false)]
                public int? DataDiskMinSize { get; set; }

                /// <summary>
                /// node ID
                /// </summary>
                [NameInMap("EnsRegionIds")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIds EnsRegionIds { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIds : TeaModel {
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=false)]
                    public List<string> EnsRegionId { get; set; }

                }

                /// <summary>
                /// The supplementary information about the edge nodes.
                /// </summary>
                [NameInMap("EnsRegionIdsExtends")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtends EnsRegionIdsExtends { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtends : TeaModel {
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId> EnsRegionId { get; set; }
                    public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId : TeaModel {
                        /// <summary>
                        /// The region.
                        /// </summary>
                        [NameInMap("Area")]
                        [Validation(Required=false)]
                        public string Area { get; set; }

                        /// <summary>
                        /// The name. This parameter is empty by default.
                        /// </summary>
                        [NameInMap("EnName")]
                        [Validation(Required=false)]
                        public string EnName { get; set; }

                        /// <summary>
                        /// The ID of the edge node.
                        /// </summary>
                        [NameInMap("EnsRegionId")]
                        [Validation(Required=false)]
                        public string EnsRegionId { get; set; }

                        /// <summary>
                        /// The information about the Internet service provider (ISP).
                        /// </summary>
                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

                        /// <summary>
                        /// The name of the edge node.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The province.
                        /// </summary>
                        [NameInMap("Province")]
                        [Validation(Required=false)]
                        public string Province { get; set; }

                    }

                }

                [NameInMap("InstanceSpeces")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceInstanceSpeces InstanceSpeces { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceInstanceSpeces : TeaModel {
                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public List<string> InstanceSpec { get; set; }

                }

                /// <summary>
                /// Operator
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceIsp Isp { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceIsp : TeaModel {
                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public List<string> Isp { get; set; }

                }

                /// <summary>
                /// The maximum size of the system disk. Unit: GiB.
                /// </summary>
                [NameInMap("SystemDiskMaxSize")]
                [Validation(Required=false)]
                public int? SystemDiskMaxSize { get; set; }

                /// <summary>
                /// The minimum capacity of a system disk. Unit: GB.
                /// </summary>
                [NameInMap("SystemDiskMinSize")]
                [Validation(Required=false)]
                public int? SystemDiskMinSize { get; set; }

            }

        }

    }

}
