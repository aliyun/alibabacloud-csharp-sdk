// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. 0 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyImages Images { get; set; }
        public class DescribeAvailableResourceResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyImagesImage> Image { get; set; }
            public class DescribeAvailableResourceResponseBodyImagesImage : TeaModel {
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
        /// The ID of the request. This is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The specifications of resources that you can purchase.
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodySupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// The size of the data disk. Unit: GB.
                /// </summary>
                [NameInMap("DataDiskSize")]
                [Validation(Required=false)]
                public string DataDiskSize { get; set; }

                /// <summary>
                /// The ID of the edge node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The specifications of the resource plan.
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
                /// The size of the system disk. Unit: GiB.
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public string SystemDiskSize { get; set; }

            }

        }

    }

}
