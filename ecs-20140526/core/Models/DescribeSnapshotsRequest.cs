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
            /// <para>The filter key used when querying resources. The value must be <c>CreationStartTime</c>. If you specify both <c>Filter.1.Key</c> and <c>Filter.1.Value</c>, you can query the resources created after the specified point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value used when querying resources. If you specify this parameter, you must also specify the <c>Filter.1.Key</c> parameter. The value must be in the <c>yyyy-MM-ddTHH:mmZ</c> format and use the UTC+0 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-12-13T17:00Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The snapshot category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: Standard snapshot.</description></item>
        /// <item><description>Flash: Local snapshot. This value will soon be deprecated. Local snapshots are replaced by the snapshot instant access feature. The parameter description is as follows:<list type="bullet">
        /// <item><description>If you used local snapshots before December 14, 2020, you can use this parameter normally.</description></item>
        /// <item><description>If you did not use local snapshots before December 14, 2020, you cannot use this parameter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>archive: Archive snapshot.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/noticelist/articleid/1060755542.html">Notice on Alibaba Cloud Snapshot Service Upgrade and New Billing Items on December 14</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The ID of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform a dry run for this request.</para>
        /// <list type="bullet">
        /// <item><description>true: The system sends a check request without querying resources. The check items include whether the AccessKey pair is valid, the authorization of Resource Access Management (RAM) users, and whether required parameters are specified. If the check fails, the system returns an error. If the check succeeds, the system returns the error code DryRunOperation.</description></item>
        /// <item><description>false (default): The system sends a normal request. If the request passes the check, the system returns an HTTP status code 2xx and queries resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter encrypted snapshots. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The specified instance ID. This parameter specifies the instance whose disk snapshots you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key that corresponds to the data disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. You can obtain the token from the response of the previous request.</para>
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
        /// <para>This parameter will be deprecated soon. We recommend that you use the NextToken and MaxResults parameters to perform a paged query.</para>
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
        /// <para>This parameter will be deprecated soon. We recommend that you use the NextToken and MaxResults parameters to perform a paged query.</para>
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
        /// <para>The ID of the resource group. When you use this parameter to filter resources, the resource count cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
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
        /// <para>The snapshot IDs. The value can be a JSON array that consists of up to 100 snapshot IDs. Separate multiple IDs with commas (,).</para>
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
        /// <para>The automatic creation type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>auto: The snapshot is automatically created.</description></item>
        /// <item><description>user: The snapshot is manually created.</description></item>
        /// <item><description>all (default): All automatic creation types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// <para>The type of the source disk from which the snapshot is created. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>system: System disk.</description></item>
        /// <item><description>data: Data disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The values are not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("SourceDiskType")]
        [Validation(Required=false)]
        public string SourceDiskType { get; set; }

        /// <summary>
        /// <para>The snapshot status. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>progressing: The snapshot is being created.</description></item>
        /// <item><description>accomplished: The snapshot is created.</description></item>
        /// <item><description>failed: The snapshot fails to be created.</description></item>
        /// <item><description>all (default): All snapshot statuses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsRequestTag> Tag { get; set; }
        public class DescribeSnapshotsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the snapshot. Valid values of N: 1 to 20.</para>
            /// <para>If you use a single tag to filter resources, the resource count under this tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources that are attached with multiple tags cannot exceed 1,000. If the resource count exceeds 1,000, use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the snapshot. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The usage of the snapshot. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>image: The snapshot is used to create a custom image.</description></item>
        /// <item><description>disk: The snapshot is used to create a disk.</description></item>
        /// <item><description>image_disk: The snapshot is used to create a data disk and a custom image.</description></item>
        /// <item><description>none: The snapshot is not used.</description></item>
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
