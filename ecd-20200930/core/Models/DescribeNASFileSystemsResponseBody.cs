// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNASFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The NAS file system information.</para>
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public List<DescribeNASFileSystemsResponseBodyFileSystems> FileSystems { get; set; }
        public class DescribeNASFileSystemsResponseBodyFileSystems : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This field is not publicly available.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AllowOperateUserDrive")]
            [Validation(Required=false)]
            public bool? AllowOperateUserDrive { get; set; }

            /// <summary>
            /// <para>The list of cloud application delivery group objects bound to the UPM-supported NAS file system.</para>
            /// </summary>
            [NameInMap("AppInstanceGroups")]
            [Validation(Required=false)]
            public List<DescribeNASFileSystemsResponseBodyFileSystemsAppInstanceGroups> AppInstanceGroups { get; set; }
            public class DescribeNASFileSystemsResponseBodyFileSystemsAppInstanceGroups : TeaModel {
                /// <summary>
                /// <para>The delivery group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aig-0bz55ibznu9p7****</para>
                /// </summary>
                [NameInMap("AppInstanceGroupId")]
                [Validation(Required=false)]
                public string AppInstanceGroupId { get; set; }

                /// <summary>
                /// <para>The delivery group name.</para>
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
            /// <item><description>If the storage type is Capacity, the capacity is fixed at 10 PiB (10485760 GiB).</description></item>
            /// <item><description>If the storage type is Performance, the capacity is fixed at 1 PiB (1048576 GiB).</description></item>
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
            /// <para>The NAS file system description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of shared cloud computer objects bound to the UPM-supported NAS file system.</para>
            /// </summary>
            [NameInMap("DesktopGroups")]
            [Validation(Required=false)]
            public List<DescribeNASFileSystemsResponseBodyFileSystemsDesktopGroups> DesktopGroups { get; set; }
            public class DescribeNASFileSystemsResponseBodyFileSystemsDesktopGroups : TeaModel {
                /// <summary>
                /// <para>The shared cloud computer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dg-9eeyf15b25nyl****</para>
                /// </summary>
                [NameInMap("DesktopGroupId")]
                [Validation(Required=false)]
                public string DesktopGroupId { get; set; }

                /// <summary>
                /// <para>The shared cloud computer name.</para>
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
            /// <para>The NAS file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04f314****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The NAS file system name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testNAS</para>
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// <para>The NAS file system status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("FileSystemStatus")]
            [Validation(Required=false)]
            public string FileSystemStatus { get; set; }

            /// <summary>
            /// <para>The type of the NAS file system. Currently, only the general-purpose type is supported, which is <c>standard</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            /// <summary>
            /// <para>The used capacity of the NAS file system. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MeteredSize")]
            [Validation(Required=false)]
            public long? MeteredSize { get; set; }

            /// <summary>
            /// <para>The mount target domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04f314****-at***.cn-hangzhou.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// <para>The mount target status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("MountTargetStatus")]
            [Validation(Required=false)]
            public string MountTargetStatus { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The office network name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The list of office networks.</para>
            /// </summary>
            [NameInMap("OfficeSites")]
            [Validation(Required=false)]
            public List<DescribeNASFileSystemsResponseBodyFileSystemsOfficeSites> OfficeSites { get; set; }
            public class DescribeNASFileSystemsResponseBodyFileSystemsOfficeSites : TeaModel {
                /// <summary>
                /// <para>The office network ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+dir-363353****</para>
                /// </summary>
                [NameInMap("OfficeSiteId")]
                [Validation(Required=false)]
                public string OfficeSiteId { get; set; }

                /// <summary>
                /// <para>The office network name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DemoOfficeNetwork</para>
                /// </summary>
                [NameInMap("OfficeSiteName")]
                [Validation(Required=false)]
                public string OfficeSiteName { get; set; }

            }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>Indicates whether the User Profile Management (UPM) feature is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProfileCompatible")]
            [Validation(Required=false)]
            public bool? ProfileCompatible { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

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
            /// <para>The storage mode of the NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Upm</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("SizeQuota")]
            [Validation(Required=false)]
            public long? SizeQuota { get; set; }

            /// <summary>
            /// <para>The storage type of the NAS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Capacity</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>Indicates whether the SMB ACL feature is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportAcl")]
            [Validation(Required=false)]
            public bool? SupportAcl { get; set; }

            /// <summary>
            /// <para>The zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-f</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC21DB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
