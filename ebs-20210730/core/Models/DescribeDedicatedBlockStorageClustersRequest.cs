// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClustersRequest : TeaModel {
        /// <summary>
        /// <para>The zone ID of the dedicated block storage cluster. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-heyuan-b</para>
        /// </summary>
        [NameInMap("AzoneId")]
        [Validation(Required=false)]
        public string AzoneId { get; set; }

        /// <summary>
        /// <para>The category of disks that can be created in the dedicated block storage cluster.</para>
        /// <para>Set the value to cloud_essd. Only enhanced SSDs (ESSDs) can be created in dedicated block storage clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DedicatedBlockStorageClusterId")]
        [Validation(Required=false)]
        public List<string> DedicatedBlockStorageClusterId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the dedicated block storage cluster. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>rg-acfmvs4****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The states of dedicated block storage clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Preparing</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Expired</description></item>
        /// <item><description>Offline</description></item>
        /// </list>
        /// <para>Multiple states can be specified. Valid values of N: 1, 2, 3, and 4.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The tags. Up to 20 tags are supported.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDedicatedBlockStorageClustersRequestTag> Tag { get; set; }
        public class DescribeDedicatedBlockStorageClustersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
