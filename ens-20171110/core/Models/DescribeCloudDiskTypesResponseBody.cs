// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCloudDiskTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77990CEE-B714-5702-BDE6-943F702277DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The specifications of resources that you can purchase.</para>
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeCloudDiskTypesResponseBodySupportResources SupportResources { get; set; }
        public class DescribeCloudDiskTypesResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeCloudDiskTypesResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeCloudDiskTypesResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// <para>The category of the disk.</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: all-flash disk.</description></item>
                /// <item><description>local_hdd: local HDD.</description></item>
                /// <item><description>local_ssd: local SSD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The ID of the edge node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-guangzhou-10</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

            }

        }

    }

}
