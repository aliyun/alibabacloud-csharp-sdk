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
            /// <para>The key of filter 1 that is used to query resources. Set the value to <c>CreationStartTime</c>. You can specify a time by configuring both <c>Filter.1.Key</c> and <c>Filter.1.Value</c> to query resources that were created after the time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of filter 1 that is used to query resources. Set the value to a time. If you configure this parameter, you must also configure <c>Filter.1.Key</c>. Specify the time in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
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
        /// <item><description><para>Standard: standard snapshot.</para>
        /// </description></item>
        /// <item><description><para>Flash: local snapshot. This value will be deprecated. The local snapshot feature is replaced by the instant access feature. When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you have used local snapshots before December 14, 2020, you can use this parameter.</description></item>
        /// <item><description>If you have not used local snapshots before December 14, 2020, you cannot use this parameter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>archive: archive snapshot.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The disk ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks your AccessKey pair, the permissions of the RAM user, and the required parameters. If the request passes the dry run, the DryRunOperation error code is returned. Otherwise, an error message is returned.</description></item>
        /// <item><description>false (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the snapshot is encrypted. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the instance whose cloud disk snapshots you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key that is used for the data disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
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
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
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
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the disk. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. If you configure this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.</para>
        /// <remarks>
        /// <para>Resources in the default resource group are displayed in the response regardless of whether you configure this parameter.</para>
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
        /// <para>The IDs of snapshots. You can specify a JSON array that consists of up to 100 snapshot IDs. Separate the snapshot IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;s-bp67acfmxazb4p****&quot;, &quot;s-bp67acfmxazb5p****&quot;, … &quot;s-bp67acfmxazb6p****&quot;]</para>
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public string SnapshotIds { get; set; }

        /// <summary>
        /// <para>The snapshot chain ID. You can specify a JSON array that contains up to 100 snapshot chain IDs. Separate the snapshot chain IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sl-bp1grgphbcc9brb5****&quot;, &quot;sl-bp1c4izumvq0i5bs****&quot;, … &quot;sl-bp1akk7isz866dds****&quot;]</para>
        /// </summary>
        [NameInMap("SnapshotLinkId")]
        [Validation(Required=false)]
        public string SnapshotLinkId { get; set; }

        /// <summary>
        /// <para>The name of the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSnapshotName</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// <para>The type of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>auto: automatic snapshot</description></item>
        /// <item><description>user: manual snapshot</description></item>
        /// <item><description>all (default): all snapshot types</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// <para>The source disk type of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: system disk.</description></item>
        /// <item><description>data: data disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of this parameter is case-insensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Data</para>
        /// </summary>
        [NameInMap("SourceDiskType")]
        [Validation(Required=false)]
        public string SourceDiskType { get; set; }

        /// <summary>
        /// <para>The status of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>progressing: The snapshot is being created.</description></item>
        /// <item><description>accomplished: The snapshot is created.</description></item>
        /// <item><description>failed: The snapshot fails to be created.</description></item>
        /// <item><description>all (default): This value indicates all snapshot states.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the snapshot.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsRequestTag> Tag { get; set; }
        public class DescribeSnapshotsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the snapshot. Valid values of N: 1 to 20</para>
            /// <para>If a single tag is specified to query resources, up to 1,000 resources that have this tag added are returned. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added are returned. To query more than 1,000 resources with the specified tags, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the snapshot. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the snapshot has been used to create custom images or disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image: The snapshot has been used to create custom images.</description></item>
        /// <item><description>disk: The snapshot has been used to create disks.</description></item>
        /// <item><description>image_disk: The snapshot has been used to create both custom images and data disks.</description></item>
        /// <item><description>none: The snapshot has not been used to create custom images or disks.</description></item>
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
