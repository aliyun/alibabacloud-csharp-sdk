// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNASFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the NAS file systems.</para>
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public List<DescribeNASFileSystemsResponseBodyFileSystems> FileSystems { get; set; }
        public class DescribeNASFileSystemsResponseBodyFileSystems : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AllowOperateUserDrive")]
            [Validation(Required=false)]
            public bool? AllowOperateUserDrive { get; set; }

            /// <summary>
            /// <para>The array of the app steaming delivery groups bound with UPM-supported NAS.</para>
            /// </summary>
            [NameInMap("AppInstanceGroups")]
            [Validation(Required=false)]
            public List<DescribeNASFileSystemsResponseBodyFileSystemsAppInstanceGroups> AppInstanceGroups { get; set; }
            public class DescribeNASFileSystemsResponseBodyFileSystemsAppInstanceGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the delivery group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aig-0bz55ibznu9p7****</para>
                /// </summary>
                [NameInMap("AppInstanceGroupId")]
                [Validation(Required=false)]
                public string AppInstanceGroupId { get; set; }

                /// <summary>
                /// <para>The name of the delivery group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DemoDeliveryGroup</para>
                /// </summary>
                [NameInMap("AppInstanceGroupName")]
                [Validation(Required=false)]
                public string AppInstanceGroupName { get; set; }

            }

            /// <summary>
            /// <para>The total capacity of the NAS file system. Unit: GiB.</para>
            /// <list type="bullet">
            /// <item><description>The Capacity type has 10 PiB of storage, which is equal to 10,485,760 GiB.</description></item>
            /// <item><description>The Performance type has 1 PiB of storage, which is equal to 1,048,576 GiB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10485760</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The time when the NAS file system was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-10T11:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The desktop groups that are associated with the NAS file systems that support the UPM feature.</para>
            /// </summary>
            [NameInMap("DesktopGroups")]
            [Validation(Required=false)]
            public List<DescribeNASFileSystemsResponseBodyFileSystemsDesktopGroups> DesktopGroups { get; set; }
            public class DescribeNASFileSystemsResponseBodyFileSystemsDesktopGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the desktop group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dg-9eeyf15b25nyl****</para>
                /// </summary>
                [NameInMap("DesktopGroupId")]
                [Validation(Required=false)]
                public string DesktopGroupId { get; set; }

                /// <summary>
                /// <para>The name of the desktop group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_dg</para>
                /// </summary>
                [NameInMap("DesktopGroupName")]
                [Validation(Required=false)]
                public string DesktopGroupName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether disk encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EncryptionEnabled")]
            [Validation(Required=false)]
            public bool? EncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04f314****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The name of the NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testNAS</para>
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// <para>The status of the NAS file system. The possible values include:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The NAS file system is being created.</description></item>
            /// <item><description>Running: The NAS file system is running.</description></item>
            /// <item><description>Stopped: The NAS file system is stopped.</description></item>
            /// <item><description>Deleting: The NAS file system is being deleted.</description></item>
            /// <item><description>Deleted: The NAS file system is deleted.</description></item>
            /// <item><description>Invalid: The NAS file system is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("FileSystemStatus")]
            [Validation(Required=false)]
            public string FileSystemStatus { get; set; }

            /// <summary>
            /// <para>The type of the NAS file system. Valid value: Universal NAS. This value indicates that the NAS file system is a General-purpose one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            /// <summary>
            /// <para>The used storage of the NAS file system. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MeteredSize")]
            [Validation(Required=false)]
            public long? MeteredSize { get; set; }

            /// <summary>
            /// <para>The domain name of the mount target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04f314****-at***.cn-hangzhou.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// <para>The status of the mount target. The possible values include:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The mount target is being created.</description></item>
            /// <item><description>Active: The mount target is enabled.</description></item>
            /// <item><description>Inactive: The mount target is disabled.</description></item>
            /// <item><description>Deleting: The mount target is being deleted.</description></item>
            /// <item><description>Invalid: The mount target is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("MountTargetStatus")]
            [Validation(Required=false)]
            public string MountTargetStatus { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The array of office networks.</para>
            /// </summary>
            [NameInMap("OfficeSites")]
            [Validation(Required=false)]
            public List<DescribeNASFileSystemsResponseBodyFileSystemsOfficeSites> OfficeSites { get; set; }
            public class DescribeNASFileSystemsResponseBodyFileSystemsOfficeSites : TeaModel {
                /// <summary>
                /// <para>The ID of the office network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+dir-363353****</para>
                /// </summary>
                [NameInMap("OfficeSiteId")]
                [Validation(Required=false)]
                public string OfficeSiteId { get; set; }

                /// <summary>
                /// <para>The name of the office network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DemoOfficeNetwork</para>
                /// </summary>
                [NameInMap("OfficeSiteName")]
                [Validation(Required=false)]
                public string OfficeSiteName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the User Profile Management (UPM) feature is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProfileCompatible")]
            [Validation(Required=false)]
            public bool? ProfileCompatible { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The storage type of the NAS file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Upm: UPM NAS</description></item>
            /// <item><description>ShareNas: Shared NAS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Upm</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The storage type of the NAS file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Capacity</description></item>
            /// <item><description>Performance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Capacity</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>Indicates whether the Server Message Block (SMB) access control list (ACL) feature was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportAcl")]
            [Validation(Required=false)]
            public bool? SupportAcl { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the NAS file system resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-f</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The token that determines the start point of the next query. This parameter is empty if no additional results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC21DB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
