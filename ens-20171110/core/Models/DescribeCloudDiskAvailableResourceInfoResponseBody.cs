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

        /// <summary>
        /// <para>The specifications of resources that you can purchase.</para>
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources SupportResources { get; set; }
        public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// <para>Node product capability.</para>
                /// </summary>
                [NameInMap("Ability")]
                [Validation(Required=false)]
                public DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResourceAbility Ability { get; set; }
                public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResourceAbility : TeaModel {
                    [NameInMap("Ability")]
                    [Validation(Required=false)]
                    public List<string> Ability { get; set; }

                }

                /// <summary>
                /// <para>The number of disks that you can purchase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CanBuyCount")]
                [Validation(Required=false)]
                public long? CanBuyCount { get; set; }

                /// <summary>
                /// <para>The type of the disk.</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: all-flash disk.</description></item>
                /// <item><description>local_hdd: local HDD.</description></item>
                /// <item><description>local_ssd: local SSD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The default size of the disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DefaultDiskSize")]
                [Validation(Required=false)]
                public long? DefaultDiskSize { get; set; }

                /// <summary>
                /// <para>The maximum size of the disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("DiskMaxSize")]
                [Validation(Required=false)]
                public long? DiskMaxSize { get; set; }

                /// <summary>
                /// <para>The minimum size of the disk size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DiskMinSize")]
                [Validation(Required=false)]
                public long? DiskMinSize { get; set; }

                /// <summary>
                /// <para>The ID of the edge node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-cmcc</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The name of the task node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing Mobile</para>
                /// </summary>
                [NameInMap("EnsRegionName")]
                [Validation(Required=false)]
                public string EnsRegionName { get; set; }

            }

        }

    }

}
