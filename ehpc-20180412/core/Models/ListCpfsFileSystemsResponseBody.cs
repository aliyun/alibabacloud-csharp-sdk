// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCpfsFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried file systems.</para>
        /// </summary>
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public ListCpfsFileSystemsResponseBodyFileSystemList FileSystemList { get; set; }
        public class ListCpfsFileSystemsResponseBodyFileSystemList : TeaModel {
            [NameInMap("FileSystems")]
            [Validation(Required=false)]
            public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystems> FileSystems { get; set; }
            public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystems : TeaModel {
                /// <summary>
                /// <para>The capacity of the file system. Unit: GiB</para>
                /// 
                /// <b>Example:</b>
                /// <para>5120</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

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
                /// <para>FilsDestription</para>
                /// </summary>
                [NameInMap("Destription")]
                [Validation(Required=false)]
                public string Destription { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>096751****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The mount targets of the file systems.</para>
                /// </summary>
                [NameInMap("MountTargetList")]
                [Validation(Required=false)]
                public ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList MountTargetList { get; set; }
                public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList : TeaModel {
                    [NameInMap("MountTargets")]
                    [Validation(Required=false)]
                    public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets> MountTargets { get; set; }
                    public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets : TeaModel {
                        /// <summary>
                        /// <para>The domain in which the mount target resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c0967****.cn-hangzhou.cpfs.nas.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        /// <summary>
                        /// <para>The network type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>VPC</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The status of the mount target. Valid values:</para>
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
                /// <para>The protocol type that is applied to the mounted file system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NFS</description></item>
                /// <item><description>SMB</description></item>
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
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

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
        /// <para>2B900AFE-C938-4551-86E9-97E231BBC876</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
