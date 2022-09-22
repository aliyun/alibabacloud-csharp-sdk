// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceInfoResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeAvailableResourceInfoResponseBodyImages Images { get; set; }
        public class DescribeAvailableResourceInfoResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceInfoResponseBodyImagesImage> Image { get; set; }
            public class DescribeAvailableResourceInfoResponseBodyImagesImage : TeaModel {
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public int? ImageSize { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceInfoResponseBodySupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceInfoResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResource : TeaModel {
                [NameInMap("BandwidthTypes")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceBandwidthTypes BandwidthTypes { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceBandwidthTypes : TeaModel {
                    [NameInMap("BandwidthType")]
                    [Validation(Required=false)]
                    public List<string> BandwidthType { get; set; }

                }

                [NameInMap("DataDiskMaxSize")]
                [Validation(Required=false)]
                public int? DataDiskMaxSize { get; set; }

                [NameInMap("DataDiskMinSize")]
                [Validation(Required=false)]
                public int? DataDiskMinSize { get; set; }

                [NameInMap("EnsRegionIds")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIds EnsRegionIds { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIds : TeaModel {
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=false)]
                    public List<string> EnsRegionId { get; set; }

                }

                [NameInMap("EnsRegionIdsExtends")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtends EnsRegionIdsExtends { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtends : TeaModel {
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId> EnsRegionId { get; set; }
                    public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId : TeaModel {
                        [NameInMap("Area")]
                        [Validation(Required=false)]
                        public string Area { get; set; }

                        [NameInMap("EnName")]
                        [Validation(Required=false)]
                        public string EnName { get; set; }

                        [NameInMap("EnsRegionId")]
                        [Validation(Required=false)]
                        public string EnsRegionId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

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

                [NameInMap("SystemDiskMaxSize")]
                [Validation(Required=false)]
                public int? SystemDiskMaxSize { get; set; }

                [NameInMap("SystemDiskMinSize")]
                [Validation(Required=false)]
                public int? SystemDiskMinSize { get; set; }

            }

        }

    }

}
