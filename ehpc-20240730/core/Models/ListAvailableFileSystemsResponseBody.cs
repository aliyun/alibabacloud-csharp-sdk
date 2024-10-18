// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListAvailableFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The file systems.</para>
        /// </summary>
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public List<ListAvailableFileSystemsResponseBodyFileSystemList> FileSystemList { get; set; }
        public class ListAvailableFileSystemsResponseBodyFileSystemList : TeaModel {
            /// <summary>
            /// <para>The time when the file system was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-7-29 15:43:53</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fa0248***</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The type of the file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: general-purpose network-attached storage (NAS) file system</description></item>
            /// <item><description>extreme: extreme NAS file system</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cpfs</para>
            /// </summary>
            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            /// <summary>
            /// <para>The mount targets of the file system.</para>
            /// </summary>
            [NameInMap("MountTargetList")]
            [Validation(Required=false)]
            public List<ListAvailableFileSystemsResponseBodyFileSystemListMountTargetList> MountTargetList { get; set; }
            public class ListAvailableFileSystemsResponseBodyFileSystemListMountTargetList : TeaModel {
                /// <summary>
                /// <para>The address of the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c0967****.cn-hangzhou.cpfs.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                /// <summary>
                /// <para>The network type. Valid values: Valid values:</para>
                /// <list type="bullet">
                /// <item><description>vpc</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The state of the mount target. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Active: The mount target is available.</description></item>
                /// <item><description>Inactive: The mount target is unavailable.</description></item>
                /// <item><description>Pending: The mount target is being mounted.</description></item>
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
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-2ze0c41hwu7lc29ris***</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbvb34rtyh6xb3zrehs1****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The protocol type of the file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nfs</description></item>
            /// <item><description>smb</description></item>
            /// <item><description>cpfs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cpfs</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The state of the file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The file system is processing a task.</description></item>
            /// <item><description>Running: The file system is available. You can perform subsequent operations, such as creating a mount target, only when the file system is in the Running state.</description></item>
            /// <item><description>Stopped: The file system is unavailable.</description></item>
            /// <item><description>Extending: The file system is being scaled out.</description></item>
            /// <item><description>Stopping: The file system is being stopped.</description></item>
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
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp132kgui8n0targb****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
        /// <para>The number of entries per page.</para>
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
        /// <para>BF4E8AB1-02A3-5ECF-87CC-3AB7BE98**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
