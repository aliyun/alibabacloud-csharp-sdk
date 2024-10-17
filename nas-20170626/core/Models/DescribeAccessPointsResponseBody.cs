// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access point.</para>
        /// </summary>
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<DescribeAccessPointsResponseBodyAccessPoints> AccessPoints { get; set; }
        public class DescribeAccessPointsResponseBodyAccessPoints : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:nas:cn-hangzhou:178321033379****:accesspoint/ap-ie15yd****</para>
            /// </summary>
            [NameInMap("ARN")]
            [Validation(Required=false)]
            public string ARN { get; set; }

            /// <summary>
            /// <para>The name of the permission group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public string AccessGroup { get; set; }

            /// <summary>
            /// <para>The ID of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15yd****</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The name of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            /// <summary>
            /// <para>The time when the access point was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709619668276167</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The domain name of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15ydanoz.001014****-w****.cn-hangzhou.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Indicates whether the Resource Access Management (RAM) policy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnabledRam")]
            [Validation(Required=false)]
            public bool? EnabledRam { get; set; }

            /// <summary>
            /// <para>The ID of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31a8e4****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The time when the access point was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709619668276167</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The Portable Operating System Interface for UNIX (POSIX) user.</para>
            /// </summary>
            [NameInMap("PosixUser")]
            [Validation(Required=false)]
            public DescribeAccessPointsResponseBodyAccessPointsPosixUser PosixUser { get; set; }
            public class DescribeAccessPointsResponseBodyAccessPointsPosixUser : TeaModel {
                /// <summary>
                /// <para>The ID of the POSIX user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PosixGroupId")]
                [Validation(Required=false)]
                public int? PosixGroupId { get; set; }

                /// <summary>
                /// <para>The IDs of the secondary user groups.</para>
                /// </summary>
                [NameInMap("PosixSecondaryGroupIds")]
                [Validation(Required=false)]
                public List<int?> PosixSecondaryGroupIds { get; set; }

                /// <summary>
                /// <para>The ID of the POSIX user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PosixUserId")]
                [Validation(Required=false)]
                public int? PosixUserId { get; set; }

            }

            /// <summary>
            /// <para>The root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("RootPath")]
            [Validation(Required=false)]
            public string RootPath { get; set; }

            /// <summary>
            /// <para>The permissions on the root directory.</para>
            /// </summary>
            [NameInMap("RootPathPermission")]
            [Validation(Required=false)]
            public DescribeAccessPointsResponseBodyAccessPointsRootPathPermission RootPathPermission { get; set; }
            public class DescribeAccessPointsResponseBodyAccessPointsRootPathPermission : TeaModel {
                /// <summary>
                /// <para>The ID of the owner group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("OwnerGroupId")]
                [Validation(Required=false)]
                public long? OwnerGroupId { get; set; }

                /// <summary>
                /// <para>The owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public long? OwnerUserId { get; set; }

                /// <summary>
                /// <para>The POSIX permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0755</para>
                /// </summary>
                [NameInMap("Permission")]
                [Validation(Required=false)]
                public string Permission { get; set; }

            }

            /// <summary>
            /// <para>The status of the root directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The rootpath status is unknown.</description></item>
            /// <item><description>1: The rootpath does not exist and may be deleted.</description></item>
            /// <item><description>2: The rootpath is normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RootPathStatus")]
            [Validation(Required=false)]
            public string RootPathStatus { get; set; }

            /// <summary>
            /// <para>The status of the access point.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The access point is available.</description></item>
            /// <item><description>Inactive: The access point is unavailable.</description></item>
            /// <item><description>Pending: The access point is being created.</description></item>
            /// <item><description>Deleting: The access point is being deleted.</description></item>
            /// </list>
            /// <remarks>
            /// <para> You can mount a file system only if the access point is in the Active state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zevmwkwyztjuoffg****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zesj9afh3y518k9o****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTY4NzcxOTcwMjAzMDk2Nzc0MyM4MDM4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6299428C-3861-435D-AE54-9B330A00****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of access points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
