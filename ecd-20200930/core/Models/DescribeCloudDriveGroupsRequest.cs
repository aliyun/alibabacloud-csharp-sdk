// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDriveGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise cloud drive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai+cds-135515****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The ID of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-jedbpr4sl9l37****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The name of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDirectoryName</para>
        /// </summary>
        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// <para>The status of the team workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("DriveStatus")]
        [Validation(Required=false)]
        public string DriveStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether a workspace is added. By default, this parameter is left empty, which indicates that all workspaces are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>binding</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DriveType")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        /// <summary>
        /// <para>The IDs of the team workspaces.</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public List<string> GroupId { get; set; }

        /// <summary>
        /// <para>The name of the team workspace. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTeam1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The team type. By default, this parameter is left empty, which indicates that all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page during paging in a paged query.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100</description></item>
        /// <item><description>Default value: 20</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the <c>NextToken</c> value returned from the last call. You do not need to specify this parameter for the first call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6lY3I2VNHLwy+nIoSXh****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the parent node of the object to be queried. To query the root node, set this parameter to <c>root</c>. By default, this parameter is left empty, which indicates that all objects are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-e70ga4ixp30ur****</para>
        /// </summary>
        [NameInMap("ParentGroupId")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the list of regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
