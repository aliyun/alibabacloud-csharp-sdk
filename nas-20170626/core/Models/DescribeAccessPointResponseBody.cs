// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessPointResponseBody : TeaModel {
        /// <summary>
        /// <para>The access point information.</para>
        /// </summary>
        [NameInMap("AccessPoint")]
        [Validation(Required=false)]
        public DescribeAccessPointResponseBodyAccessPoint AccessPoint { get; set; }
        public class DescribeAccessPointResponseBodyAccessPoint : TeaModel {
            /// <summary>
            /// <para>The access point ARN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:nas:cn-hangzhou:178321033379****:accesspoint/ap-ie15yd****</para>
            /// </summary>
            [NameInMap("ARN")]
            [Validation(Required=false)]
            public string ARN { get; set; }

            /// <summary>
            /// <para>The permission group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public string AccessGroup { get; set; }

            /// <summary>
            /// <para>The access point ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15yd****</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The access point name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            /// <summary>
            /// <para>AgenticSpace Id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentic-229oypxjgpau2****</para>
            /// </summary>
            [NameInMap("AgenticSpaceId")]
            [Validation(Required=false)]
            public string AgenticSpaceId { get; set; }

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
            /// <para>The time when the AgenticSpace was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTimeUtc")]
            [Validation(Required=false)]
            public string CreateTimeUtc { get; set; }

            /// <summary>
            /// <para>The access point domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15ydanoz.001014****-w****.cn-hangzhou.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Indicates whether the RAM policy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnabledRam")]
            [Validation(Required=false)]
            public bool? EnabledRam { get; set; }

            /// <summary>
            /// <para>The file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31a8e4****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The time when the access point was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709619668276167</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The time when the AgenticSpace was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T10:08:08Z</para>
            /// </summary>
            [NameInMap("ModifyTimeUtc")]
            [Validation(Required=false)]
            public string ModifyTimeUtc { get; set; }

            /// <summary>
            /// <para>The POSIX user.</para>
            /// </summary>
            [NameInMap("PosixUser")]
            [Validation(Required=false)]
            public DescribeAccessPointResponseBodyAccessPointPosixUser PosixUser { get; set; }
            public class DescribeAccessPointResponseBodyAccessPointPosixUser : TeaModel {
                /// <summary>
                /// <para>The POSIX user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PosixGroupId")]
                [Validation(Required=false)]
                public int? PosixGroupId { get; set; }

                /// <summary>
                /// <para>The secondary user group ID.</para>
                /// </summary>
                [NameInMap("PosixSecondaryGroupIds")]
                [Validation(Required=false)]
                public List<int?> PosixSecondaryGroupIds { get; set; }

                /// <summary>
                /// <para>The POSIX user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PosixUserId")]
                [Validation(Required=false)]
                public int? PosixUserId { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            /// <para>The permissions for creating the root directory.</para>
            /// </summary>
            [NameInMap("RootPathPermission")]
            [Validation(Required=false)]
            public DescribeAccessPointResponseBodyAccessPointRootPathPermission RootPathPermission { get; set; }
            public class DescribeAccessPointResponseBodyAccessPointRootPathPermission : TeaModel {
                /// <summary>
                /// <para>The file group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("OwnerGroupId")]
                [Validation(Required=false)]
                public int? OwnerGroupId { get; set; }

                /// <summary>
                /// <para>The file owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public int? OwnerUserId { get; set; }

                /// <summary>
                /// <para>The POSIX permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0755</para>
                /// </summary>
                [NameInMap("Permission")]
                [Validation(Required=false)]
                public string Permission { get; set; }

            }

            /// <summary>
            /// <para>The current root directory status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The root path status is unknown.</description></item>
            /// <item><description>1: The root path does not exist. It may have been deleted by the user.</description></item>
            /// <item><description>2: The root path status is normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RootPathStatus")]
            [Validation(Required=false)]
            public string RootPathStatus { get; set; }

            /// <summary>
            /// <para>The current access point status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: active</description></item>
            /// <item><description>Inactive: inactive</description></item>
            /// <item><description>Pending: being created</description></item>
            /// <item><description>Deleting: being deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of access point tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeAccessPointResponseBodyAccessPointTags> Tags { get; set; }
            public class DescribeAccessPointResponseBodyAccessPointTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
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
            /// <para>The VPC must be the same as the VPC of the Elastic Computing Service (ECS) server to which you want to mount the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zesj9afh3y518k9o****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
