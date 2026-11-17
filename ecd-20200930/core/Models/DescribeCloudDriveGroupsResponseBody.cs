// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDriveGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of team workspaces in the cloud drive.</para>
        /// </summary>
        [NameInMap("CloudDriveGroups")]
        [Validation(Required=false)]
        public List<DescribeCloudDriveGroupsResponseBodyCloudDriveGroups> CloudDriveGroups { get; set; }
        public class DescribeCloudDriveGroupsResponseBodyCloudDriveGroups : TeaModel {
            /// <summary>
            /// <para>The list of team administrators.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;user01&quot;]</para>
            /// </summary>
            [NameInMap("AdminUserIds")]
            [Validation(Required=false)]
            public string AdminUserIds { get; set; }

            /// <summary>
            /// <para>The information about the administrators of the team storage management.</para>
            /// </summary>
            [NameInMap("AdminUserInfos")]
            [Validation(Required=false)]
            public List<DescribeCloudDriveGroupsResponseBodyCloudDriveGroupsAdminUserInfos> AdminUserInfos { get; set; }
            public class DescribeCloudDriveGroupsResponseBodyCloudDriveGroupsAdminUserInfos : TeaModel {
                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@aliyun.com">123@aliyun.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The username of the administrator. The username may be unreadable if it is imported from a third-party system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user01</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The employee ID in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

                /// <summary>
                /// <para>The nickname of the administrator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The nickname of the administrator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("RealNickName")]
                [Validation(Required=false)]
                public string RealNickName { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-11T07:44:21Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-959593****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh1234</para>
            /// </summary>
            [NameInMap("DriveId")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// <para>The ID of the team workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-e70ga4ixp30ur****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the team workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestTeam1</para>
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
            /// <para>The size of the recycle bin in the team workspace. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024000</para>
            /// </summary>
            [NameInMap("RecycleBinSize")]
            [Validation(Required=false)]
            public string RecycleBinSize { get; set; }

            /// <summary>
            /// <para>The status of the team workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total capacity of the team workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5368709120</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            /// <summary>
            /// <para>The size of the used space. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024000000</para>
            /// </summary>
            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public string UsedSize { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The token for the next query. If <c>NextToken</c> is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF015AE5-B30A-5189-B519-735CEE40****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
