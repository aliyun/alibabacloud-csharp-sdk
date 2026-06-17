// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeResourcePackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of cross-cloud resource plans.</para>
        /// </summary>
        [NameInMap("ResourcePackageList")]
        [Validation(Required=false)]
        public List<DescribeResourcePackagesResponseBodyResourcePackageList> ResourcePackageList { get; set; }
        public class DescribeResourcePackagesResponseBodyResourcePackageList : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic quota allocation is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoQuota")]
            [Validation(Required=false)]
            public bool? AutoQuota { get; set; }

            /// <summary>
            /// <para>The time when the resource plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1744621511000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the resource plan expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1747238400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the cross-cloud resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pm-bp11b0i9389******</para>
            /// </summary>
            [NameInMap("ResourcePackageId")]
            [Validation(Required=false)]
            public string ResourcePackageId { get; set; }

            /// <summary>
            /// <para>The quota allocation details.</para>
            /// </summary>
            [NameInMap("ResourcePackageQuotaList")]
            [Validation(Required=false)]
            public List<DescribeResourcePackagesResponseBodyResourcePackageListResourcePackageQuotaList> ResourcePackageQuotaList { get; set; }
            public class DescribeResourcePackagesResponseBodyResourcePackageListResourcePackageQuotaList : TeaModel {
                /// <summary>
                /// <para>The capacity allocated to the resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("AllocatedCapacity")]
                [Validation(Required=false)]
                public long? AllocatedCapacity { get; set; }

                /// <summary>
                /// <para>The ID of the resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pj-87681rbcef6******</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The used capacity of the resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public long? UsedCapacity { get; set; }

            }

            /// <summary>
            /// <para>The type of the cross-cloud resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("ResourcePackageType")]
            [Validation(Required=false)]
            public string ResourcePackageType { get; set; }

            /// <summary>
            /// <para>The status of the cross-cloud resource plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: Normal.</para>
            /// </description></item>
            /// <item><description><para>Maintaining: Under maintenance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeResourcePackagesResponseBodyResourcePackageListTags> Tags { get; set; }
            public class DescribeResourcePackagesResponseBodyResourcePackageListTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The total capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public long? TotalCapacity { get; set; }

            /// <summary>
            /// <para>The used capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public long? UsedCapacity { get; set; }

        }

    }

}
