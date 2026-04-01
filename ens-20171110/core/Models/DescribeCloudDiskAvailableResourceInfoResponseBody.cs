// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCloudDiskAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AE4F26E-7527-569F-A987-E3CF269A3C11</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources SupportResources { get; set; }
        public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource : TeaModel {
                [NameInMap("Ability")]
                [Validation(Required=false)]
                public DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResourceAbility Ability { get; set; }
                public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResourceAbility : TeaModel {
                    [NameInMap("Ability")]
                    [Validation(Required=false)]
                    public List<string> Ability { get; set; }

                }

                [NameInMap("CanBuyCount")]
                [Validation(Required=false)]
                public long? CanBuyCount { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("DefaultDiskSize")]
                [Validation(Required=false)]
                public long? DefaultDiskSize { get; set; }

                [NameInMap("DiskMaxSize")]
                [Validation(Required=false)]
                public long? DiskMaxSize { get; set; }

                [NameInMap("DiskMinSize")]
                [Validation(Required=false)]
                public long? DiskMinSize { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("EnsRegionName")]
                [Validation(Required=false)]
                public string EnsRegionName { get; set; }

            }

        }

    }

}
