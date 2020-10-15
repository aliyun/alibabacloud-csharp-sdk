// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SupportResources")]
        [Validation(Required=true)]
        public DescribeAvailableResourceInfoResponseSupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceInfoResponseSupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=true)]
            public List<DescribeAvailableResourceInfoResponseSupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceInfoResponseSupportResourcesSupportResource : TeaModel {
                public int? DataDiskMinSize { get; set; }
                public int? DataDiskMaxSize { get; set; }
                public int? SystemDiskMinSize { get; set; }
                public int? SystemDiskMaxSize { get; set; }
                public DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceEnsRegionIdsExtends EnsRegionIdsExtends { get; set; }
                public class DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceEnsRegionIdsExtends : TeaModel {
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=true)]
                    public List<DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId> EnsRegionId { get; set; }
                    public class DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId : TeaModel {
                        [NameInMap("EnsRegionId")]
                        [Validation(Required=true)]
                        public string EnsRegionId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=true)]
                        public string Name { get; set; }

                        [NameInMap("EnName")]
                        [Validation(Required=true)]
                        public string EnName { get; set; }

                        [NameInMap("Area")]
                        [Validation(Required=true)]
                        public string Area { get; set; }

                        [NameInMap("Province")]
                        [Validation(Required=true)]
                        public string Province { get; set; }

                    }

                }
                public DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceEnsRegionIds EnsRegionIds { get; set; }
                public class DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceEnsRegionIds : TeaModel {
                    /// <summary>
                    /// EnsRegionId
                    /// </summary>
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=true)]
                    public List<string> EnsRegionId { get; set; }

                }
                public DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceInstanceSpeces InstanceSpeces { get; set; }
                public class DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceInstanceSpeces : TeaModel {
                    /// <summary>
                    /// InstanceSpec
                    /// </summary>
                    [NameInMap("InstanceSpec")]
                    [Validation(Required=true)]
                    public List<string> InstanceSpec { get; set; }

                }
                public DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceBandwidthTypes BandwidthTypes { get; set; }
                public class DescribeAvailableResourceInfoResponseSupportResourcesSupportResourceBandwidthTypes : TeaModel {
                    /// <summary>
                    /// BandwidthType
                    /// </summary>
                    [NameInMap("BandwidthType")]
                    [Validation(Required=true)]
                    public List<string> BandwidthType { get; set; }

                }
            }
        };

        [NameInMap("Images")]
        [Validation(Required=true)]
        public DescribeAvailableResourceInfoResponseImages Images { get; set; }
        public class DescribeAvailableResourceInfoResponseImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=true)]
            public List<DescribeAvailableResourceInfoResponseImagesImage> Image { get; set; }
            public class DescribeAvailableResourceInfoResponseImagesImage : TeaModel {
                public string ImageId { get; set; }
                public string ImageName { get; set; }
                public int? ImageSize { get; set; }
            }
        };

    }

}
