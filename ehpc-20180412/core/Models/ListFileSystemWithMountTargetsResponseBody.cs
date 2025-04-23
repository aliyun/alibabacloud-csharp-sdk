// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListFileSystemWithMountTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried file systems.</para>
        /// </summary>
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public ListFileSystemWithMountTargetsResponseBodyFileSystemList FileSystemList { get; set; }
        public class ListFileSystemWithMountTargetsResponseBodyFileSystemList : TeaModel {
            [NameInMap("FileSystems")]
            [Validation(Required=false)]
            public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystems> FileSystems { get; set; }
            public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystems : TeaModel {
                /// <summary>
                /// <para>The bandwidth of the file system. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("BandWidth")]
                [Validation(Required=false)]
                public int? BandWidth { get; set; }

                /// <summary>
                /// <para>The capacity of the file system. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5120</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public int? Capacity { get; set; }

                /// <summary>
                /// <para>The time when the file system was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-26 16:36:27</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FilesDescription</para>
                /// </summary>
                [NameInMap("Destription")]
                [Validation(Required=false)]
                public string Destription { get; set; }

                /// <summary>
                /// <para>Indicates whether data in the file system is encrypted.</para>
                /// <para>You can use keys that are managed by Key Management Service (KMS) to encrypt the data in a file system. When you read and write the encrypted data, the data is automatically decrypted.</para>
                /// <para>Default value: 0. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The data in the file system is not encrypted.</description></item>
                /// <item><description>1: The data in the file system is encrypted by using a NAS-managed key. This parameter is valid if FileSystemType is set to standard or extreme.</description></item>
                /// <item><description>2: The data in the file system is encrypted by using a KMS-managed key. This parameter is valid only if FileSystemType is set to extreme.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>088b****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The type of the file system. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>standard: general-purpose network-attached storage (NAS) file systems.</description></item>
                /// <item><description>extreme: extreme NAS file systems.</description></item>
                /// </list>
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
                /// <para>1216816455</para>
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public int? MeteredSize { get; set; }

                /// <summary>
                /// <para>The list of mount targets.</para>
                /// </summary>
                [NameInMap("MountTargetList")]
                [Validation(Required=false)]
                public ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetList MountTargetList { get; set; }
                public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetList : TeaModel {
                    [NameInMap("MountTargets")]
                    [Validation(Required=false)]
                    public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets> MountTargets { get; set; }
                    public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the permission group is the default permission group of the user.</para>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The permission group is the default permission group. In this case, all IP addresses are allowed to access the permission group, and the user cannot delete the permission group and permission rules in the permission group.</description></item>
                        /// <item><description>false: The permission group is not the default permission group.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEFAULT_VPC_GROUP_NAME</para>
                        /// </summary>
                        [NameInMap("AccessGroup")]
                        [Validation(Required=false)]
                        public string AccessGroup { get; set; }

                        /// <summary>
                        /// <para>The domain in which the mount target resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>088b****-lj2.cn-hangzhou.nas.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        /// <summary>
                        /// <para>The network type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>vpc</description></item>
                        /// <item><description>classic</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The status of the mount target. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Active: The mount target is available.</description></item>
                        /// <item><description>Inactive: The mount target is unavailable.</description></item>
                        /// <item><description>Pending: The mount target is being created or modified.</description></item>
                        /// <item><description>Deleting: The mount target is being deleted.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Active</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The ID of the virtual private cloud (VPC).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-8vbvb34rtyh6xb3zrehs1****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-8vb34rtyh6xb3zrehs1****</para>
                        /// </summary>
                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The list of storage plans.</para>
                /// </summary>
                [NameInMap("PackageList")]
                [Validation(Required=false)]
                public ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageList PackageList { get; set; }
                public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageList : TeaModel {
                    [NameInMap("Packages")]
                    [Validation(Required=false)]
                    public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageListPackages> Packages { get; set; }
                    public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageListPackages : TeaModel {
                        /// <summary>
                        /// <para>The ID of the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>naspackage-0be9c4b624-37****</para>
                        /// </summary>
                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The protocol type of the file system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NFS- SMB</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NFS</para>
                /// </summary>
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
                /// <para>The status of the file system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The file system is being created or modified.</description></item>
                /// <item><description>Running: The file system is available.</description></item>
                /// <item><description>Stopped: The file system is unavailable.</description></item>
                /// <item><description>Extending: The file system is being scaled up.</description></item>
                /// <item><description>Stopping: The file system is being disabled.</description></item>
                /// <item><description>Deleting: The file system is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage type of the file system.</para>
                /// <list type="bullet">
                /// <item><description>Valid values if FileSystemType is set to standard: Capacity and Performance.</description></item>
                /// <item><description>Valid values if FileSystemType is set to extreme: standard and advance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Performance</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp132kgui8n0targbn1cm</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25638B77-2F19-5DC5-B578-7790CE92052B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
