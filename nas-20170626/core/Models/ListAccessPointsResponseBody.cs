// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The access point information.</para>
        /// </summary>
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<ListAccessPointsResponseBodyAccessPoints> AccessPoints { get; set; }
        public class ListAccessPointsResponseBodyAccessPoints : TeaModel {
            /// <summary>
            /// <para>The ARN of the access point.</para>
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
            /// <para>DEFAULT_VPC_GROUP_NAME</para>
            /// </summary>
            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public string AccessGroup { get; set; }

            /// <summary>
            /// <para>The ID of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15y*****</para>
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
            /// <para>The AgenticSpace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentic-229oypxjgpau2****</para>
            /// </summary>
            [NameInMap("AgenticSpaceId")]
            [Validation(Required=false)]
            public string AgenticSpaceId { get; set; }

            /// <summary>
            /// <para>The time when the access point was created. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-28T06:32:14Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the Agentic space was created. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTimeUtc")]
            [Validation(Required=false)]
            public string CreateTimeUtc { get; set; }

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
            /// <para>Specifies whether the RAM policy is enabled.</para>
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
            /// <para>091yj49baxscll2****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The time when the access point was modified. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-24T02:10:23Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The time when the Agentic space was updated. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
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
            public ListAccessPointsResponseBodyAccessPointsPosixUser PosixUser { get; set; }
            public class ListAccessPointsResponseBodyAccessPointsPosixUser : TeaModel {
                /// <summary>
                /// <para>The ID of the POSIX user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PosixGroupId")]
                [Validation(Required=false)]
                public int? PosixGroupId { get; set; }

                /// <summary>
                /// <para>The IDs of the secondary user groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[100,123]</para>
                /// </summary>
                [NameInMap("PosixSecondaryGroupIds")]
                [Validation(Required=false)]
                public List<int?> PosixSecondaryGroupIds { get; set; }

                /// <summary>
                /// <para>The ID of the POSIX user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>156</para>
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
            /// <para>The permissions of the root directory.</para>
            /// </summary>
            [NameInMap("RootPathPermission")]
            [Validation(Required=false)]
            public ListAccessPointsResponseBodyAccessPointsRootPathPermission RootPathPermission { get; set; }
            public class ListAccessPointsResponseBodyAccessPointsRootPathPermission : TeaModel {
                /// <summary>
                /// <para>The ID of the owner user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("OwnerGroupId")]
                [Validation(Required=false)]
                public long? OwnerGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the owner user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public long? OwnerUserId { get; set; }

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
            /// <para>The current status of the root directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The status of the root path is unknown.</description></item>
            /// <item><description>1: The root path does not exist. It may have been deleted by the user.</description></item>
            /// <item><description>2: The status of the root path is normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RootPathStatus")]
            [Validation(Required=false)]
            public string RootPathStatus { get; set; }

            /// <summary>
            /// <para>The current status of the access point. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: The access point is available.</description></item>
            /// <item><description>inactive: The access point is unavailable.</description></item>
            /// <item><description>pending: The access point is being created.</description></item>
            /// <item><description>deleting: The access point is being deleted.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You can mount the file system only when the status is active.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags for the access point.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAccessPointsResponseBodyAccessPointsTags> Tags { get; set; }
            public class ListAccessPointsResponseBodyAccessPointsTags : TeaModel {
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
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zevmwkwyztjuoffg****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zesj9afh3y518k9o****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The query token. The value is the NextToken parameter value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52frCAAAAABoZS90cm****==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
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
