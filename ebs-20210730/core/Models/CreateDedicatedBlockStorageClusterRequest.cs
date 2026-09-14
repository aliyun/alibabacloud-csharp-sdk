// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDedicatedBlockStorageClusterRequest : TeaModel {
        /// <summary>
        /// <para>The zone ID of the dedicated block storage cluster. You can call <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to query the zone list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-heyuan-b</para>
        /// </summary>
        [NameInMap("Azone")]
        [Validation(Required=false)]
        public string Azone { get; set; }

        /// <summary>
        /// <para>The capacity of the dedicated block storage cluster. Valid values: 61440 to 2334720 GiB (2280 TiB). Minimum increment: 12288 GiB.</para>
        /// <remarks>
        /// <para>When the capacity of the dedicated block storage cluster is less than 576 TiB, the maximum throughput per TiB does not exceed 52 MB/s. When the capacity of the dedicated block storage cluster is greater than 576 TiB, the maximum throughput per TiB does not exceed 26 MB/s.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61440</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1233</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DbscId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DbscId { get; set; }

        /// <summary>
        /// <para>The name of the dedicated block storage cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myDBSCCluster</para>
        /// </summary>
        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. Valid values: 6, 7, 8, 9, 10, 11, 12, 24, and 36.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration specified by the <c>Period</c> parameter. Only Month is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the dedicated block storage cluster. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-heyuan</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the dedicated block storage cluster belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmvs*******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags. A maximum of 20 tags can be specified.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDedicatedBlockStorageClusterRequestTag> Tag { get; set; }
        public class CreateDedicatedBlockStorageClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the dedicated block storage cluster.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the dedicated block storage cluster.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The performance type of the dedicated block storage cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: basic. You can create PL0 ESSDs in this type of dedicated block storage cluster.</description></item>
        /// <item><description>Premium: performance. You can create PL1 ESSDs in this type of dedicated block storage cluster.</description></item>
        /// </list>
        /// <para>Default value: Premium.</para>
        /// <para>For more information about standard SSDs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Premium</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
