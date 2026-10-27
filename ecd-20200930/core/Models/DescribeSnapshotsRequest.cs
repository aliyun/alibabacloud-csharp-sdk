// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Administrator</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The ID of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The name of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        [NameInMap("DesktopScenario")]
        [Validation(Required=false)]
        public string DesktopScenario { get; set; }

        /// <summary>
        /// <para>The end time of the snapshot creation. The time is displayed in UTC and follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-31T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken parameter value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8051af8d01b5479bec9f5ddf02e4a8fbd0ab6e7e43f8****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The operating system type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-2ze81owrnv9pity4****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The display name of the snapshot. The name must be 2 to 127 characters in length. It must start with a letter or a Chinese character, and can contain digits, underscores (_), and hyphens (-). To prevent name conflicts with automatic snapshots, the name cannot start with <c>auto</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test data disk</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// <para>The snapshot type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// <para>The type of the disk for which you want to create a snapshot.</para>
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
        /// <para>The start time of the snapshot creation. The time is displayed in UTC and follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-30T06:32:31Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
