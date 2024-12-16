// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDriveGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of team spaces.</para>
        /// </summary>
        [NameInMap("CloudDriveGroups")]
        [Validation(Required=false)]
        public List<DescribeCloudDriveGroupsResponseBodyCloudDriveGroups> CloudDriveGroups { get; set; }
        public class DescribeCloudDriveGroupsResponseBodyCloudDriveGroups : TeaModel {
            [NameInMap("AdminUserIds")]
            [Validation(Required=false)]
            public string AdminUserIds { get; set; }

            [NameInMap("AdminUserInfos")]
            [Validation(Required=false)]
            public List<DescribeCloudDriveGroupsResponseBodyCloudDriveGroupsAdminUserInfos> AdminUserInfos { get; set; }
            public class DescribeCloudDriveGroupsResponseBodyCloudDriveGroupsAdminUserInfos : TeaModel {
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("RealNickName")]
                [Validation(Required=false)]
                public string RealNickName { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            /// <summary>
            /// <para>The time when the team space was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-11T07:44:21Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-959593****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The team space ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh1234</para>
            /// </summary>
            [NameInMap("DriveId")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// <para>The team ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-e70ga4ixp30ur****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the team space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test Team 1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            [NameInMap("RecycleBinSize")]
            [Validation(Required=false)]
            public string RecycleBinSize { get; set; }

            /// <summary>
            /// <para>The team space status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled</description></item>
            /// <item><description>disabled</description></item>
            /// </list>
            /// <para>Default value: enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total capacity of the team space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5368709120</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            /// <summary>
            /// <para>The capacity of the used space. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024000000</para>
            /// </summary>
            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public string UsedSize { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
