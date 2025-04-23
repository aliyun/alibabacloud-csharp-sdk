// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListVolumesResponseBody : TeaModel {
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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information of file systems that are mounted on E-HPC clusters.</para>
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public ListVolumesResponseBodyVolumes Volumes { get; set; }
        public class ListVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("VolumeInfo")]
            [Validation(Required=false)]
            public List<ListVolumesResponseBodyVolumesVolumeInfo> VolumeInfo { get; set; }
            public class ListVolumesResponseBodyVolumesVolumeInfo : TeaModel {
                /// <summary>
                /// <para>The information of additional file systems mounted on E-HPC clusters.</para>
                /// </summary>
                [NameInMap("AdditionalVolumes")]
                [Validation(Required=false)]
                public ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumes AdditionalVolumes { get; set; }
                public class ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumes : TeaModel {
                    [NameInMap("VolumeInfo")]
                    [Validation(Required=false)]
                    public List<ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumesVolumeInfo> VolumeInfo { get; set; }
                    public class ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumesVolumeInfo : TeaModel {
                        /// <summary>
                        /// <para>The queue to which the job belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>all.q</para>
                        /// </summary>
                        [NameInMap("JobQueue")]
                        [Validation(Required=false)]
                        public string JobQueue { get; set; }

                        /// <summary>
                        /// <para>The local mount directory.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/testopt</para>
                        /// </summary>
                        [NameInMap("LocalDirectory")]
                        [Validation(Required=false)]
                        public string LocalDirectory { get; set; }

                        /// <summary>
                        /// <para>The location where the cluster is deployed. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>OnPremise: The node is deployed on a hybrid cloud.</description></item>
                        /// <item><description>PublicCloud: The cluster is deployed on a public cloud.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PublicCloud</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <para>The remote directory on which the file system is mounted.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/test</para>
                        /// </summary>
                        [NameInMap("RemoteDirectory")]
                        [Validation(Required=false)]
                        public string RemoteDirectory { get; set; }

                        /// <summary>
                        /// <para>The type of the node on which the file system is mounted. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Manager: management node</description></item>
                        /// <item><description>Login: logon node</description></item>
                        /// <item><description>Compute: compute node</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Compute</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>The ID of the file system.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>86y3****</para>
                        /// </summary>
                        [NameInMap("VolumeId")]
                        [Validation(Required=false)]
                        public string VolumeId { get; set; }

                        /// <summary>
                        /// <para>The domain name of the mount target.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>86y3****-rgd51.cn-hangzhou.nas.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("VolumeMountpoint")]
                        [Validation(Required=false)]
                        public string VolumeMountpoint { get; set; }

                        /// <summary>
                        /// <para>The type of the storage protocol. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>NFS</description></item>
                        /// <item><description>SMB</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NFS</para>
                        /// </summary>
                        [NameInMap("VolumeProtocol")]
                        [Validation(Required=false)]
                        public string VolumeProtocol { get; set; }

                        /// <summary>
                        /// <para>The type of the additional file system. Only NAS is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NAS</para>
                        /// </summary>
                        [NameInMap("VolumeType")]
                        [Validation(Required=false)]
                        public string VolumeType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ehpc-hz-FYUr32****</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cluster1</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

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
                /// <para>The remote directory on which the file system is mounted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test1</para>
                /// </summary>
                [NameInMap("RemoteDirectory")]
                [Validation(Required=false)]
                public string RemoteDirectory { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bc8a****</para>
                /// </summary>
                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public string VolumeId { get; set; }

                /// <summary>
                /// <para>The domain name of the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bc8a****-rgd51.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("VolumeMountpoint")]
                [Validation(Required=false)]
                public string VolumeMountpoint { get; set; }

                /// <summary>
                /// <para>The type of the storage protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NFS</description></item>
                /// <item><description>SMB</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NFS</para>
                /// </summary>
                [NameInMap("VolumeProtocol")]
                [Validation(Required=false)]
                public string VolumeProtocol { get; set; }

                /// <summary>
                /// <para>The type of the file system that is mounted on the cluster. Only NAS is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAS</para>
                /// </summary>
                [NameInMap("VolumeType")]
                [Validation(Required=false)]
                public string VolumeType { get; set; }

            }

        }

    }

}
