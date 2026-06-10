// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDiskGroupDrivesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud disk team drives.</para>
        /// </summary>
        [NameInMap("CloudDriveGroups")]
        [Validation(Required=false)]
        public List<DescribeCloudDiskGroupDrivesResponseBodyCloudDriveGroups> CloudDriveGroups { get; set; }
        public class DescribeCloudDiskGroupDrivesResponseBodyCloudDriveGroups : TeaModel {
            /// <summary>
            /// <para>The time the drive was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-11T07:44:21Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-959593****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The drive ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("DriveId")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// <para>The team drive ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-e70ga4ixp30ur****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The team drive name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test team 1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The organization ID of the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-aliyun-wy-org-id</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The status of the team drive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total capacity of the cloud disk team drive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5368709120</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            /// <summary>
            /// <para>The used space size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024000000</para>
            /// </summary>
            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public string UsedSize { get; set; }

        }

        /// <summary>
        /// <para>The total number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The token that marks the start of the next query. An empty NextToken means no more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTA0MjA=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B9F9CBBE-8A9F-5FE5-8A72-0E81C2401A91</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
