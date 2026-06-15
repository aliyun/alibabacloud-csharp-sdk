// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsRequestFilter> Filter { get; set; }
        public class DescribeSnapshotsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key for querying resources. The value must be <c>CreationStartTime</c>. If you specify <c>Filter.1.Key</c> and <c>Filter.1.Value</c>, you can query for resources that were created after the specified point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value. If you specify this parameter, you must also specify <c>Filter.1.Key</c>. The value must be in the <c>yyyy-MM-ddTHH:mmZ</c> format and in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-12-13T17:00Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The category of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Standard</c>: A standard snapshot.</para>
        /// </description></item>
        /// <item><description><para><c>Flash</c>: A local snapshot. This value is deprecated because the local snapshot feature has been replaced by the instant access feature.</para>
        /// <list type="bullet">
        /// <item><description><para>If you have used local snapshots before December 14, 2020, you can continue to use this value.</para>
        /// </description></item>
        /// <item><description><para>If you have not used local snapshots before December 14, 2020, you cannot use this value.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>archive</c>: An archive snapshot.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/noticelist/articleid/1060755542.html">December 14: Alibaba Cloud snapshot service upgrade and new billing items notice</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Performs a dry run but does not query resources. The system checks the request for potential issues, including missing required parameters, invalid parameter values, and insufficient permissions. If the request is invalid, an error is returned. If the request is valid, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><c>false</c> (Default): Sends a normal request. If the request is valid, the system returns a 2xx HTTP status code and the query results.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only encrypted snapshots. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the instance. When you specify this ID, the operation returns snapshots of cloud disks attached to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key used to encrypt the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to start the next page of results. You can obtain this token from the response to a previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated. We recommend that you use the <c>NextToken</c> and <c>MaxResults</c> parameters for paged queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated. We recommend that you use the <c>NextToken</c> and <c>MaxResults</c> parameters for paged queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the snapshot belongs. When you filter by this parameter, the query can return a maximum of 1,000 snapshots.</para>
        /// <remarks>
        /// <para>You cannot filter resources that are in the default resource group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>A JSON array that contains the IDs of up to 100 snapshots to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;s-bp67acfmxazb4p****&quot;, &quot;s-bp67acfmxazb5p****&quot;, … &quot;s-bp67acfmxazb6p****&quot;]</para>
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public string SnapshotIds { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sl-bp1grgphbcc9brb5****</para>
        /// </summary>
        [NameInMap("SnapshotLinkId")]
        [Validation(Required=false)]
        public string SnapshotLinkId { get; set; }

        /// <summary>
        /// <para>The snapshot name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSnapshotName</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// <para>The snapshot creation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>auto</c>: An automatically created snapshot.</para>
        /// </description></item>
        /// <item><description><para><c>user</c>: A manually created snapshot.</para>
        /// </description></item>
        /// <item><description><para><c>all</c> (Default): All snapshot creation types.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// <para>The type of the source disk of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>system</c>: The snapshot was created from a system disk.</para>
        /// </description></item>
        /// <item><description><para><c>data</c>: The snapshot was created from a data disk.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The value is case-insensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("SourceDiskType")]
        [Validation(Required=false)]
        public string SourceDiskType { get; set; }

        /// <summary>
        /// <para>The status of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>progressing</c>: The snapshot is being created.</para>
        /// </description></item>
        /// <item><description><para><c>accomplished</c>: The snapshot is complete.</para>
        /// </description></item>
        /// <item><description><para><c>failed</c>: Snapshot creation failed.</para>
        /// </description></item>
        /// <item><description><para><c>all</c> (Default): All snapshot statuses.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags by which to filter snapshots.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsRequestTag> Tag { get; set; }
        public class DescribeSnapshotsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <para>For better compatibility, use the <c>Tag.N.Key</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The usage of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>image</c>: The snapshot is used to create a custom image.</para>
        /// </description></item>
        /// <item><description><para><c>disk</c>: The snapshot is used to create a cloud disk.</para>
        /// </description></item>
        /// <item><description><para><c>image_disk</c>: The snapshot is used to create a custom image and a data disk.</para>
        /// </description></item>
        /// <item><description><para><c>none</c>: The snapshot is not used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
