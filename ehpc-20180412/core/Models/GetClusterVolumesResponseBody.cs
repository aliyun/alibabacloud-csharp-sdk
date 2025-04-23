// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetClusterVolumesResponseBody : TeaModel {
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BCFD52E-0336-4490-AE7D-F560F106****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the file system mounted to the E-HPC cluster.</para>
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public GetClusterVolumesResponseBodyVolumes Volumes { get; set; }
        public class GetClusterVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("VolumeInfo")]
            [Validation(Required=false)]
            public List<GetClusterVolumesResponseBodyVolumesVolumeInfo> VolumeInfo { get; set; }
            public class GetClusterVolumesResponseBodyVolumesVolumeInfo : TeaModel {
                /// <summary>
                /// <para>The queue of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workq</para>
                /// </summary>
                [NameInMap("JobQueue")]
                [Validation(Required=false)]
                public string JobQueue { get; set; }

                /// <summary>
                /// <para>The local mount directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/ehpcdata</para>
                /// </summary>
                [NameInMap("LocalDirectory")]
                [Validation(Required=false)]
                public string LocalDirectory { get; set; }

                /// <summary>
                /// <para>The type of cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OnPremise: The cluster is deployed on a hybrid cloud.</description></item>
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
                /// <para>Indicates whether the resource can be unmounted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MustKeep")]
                [Validation(Required=false)]
                public bool? MustKeep { get; set; }

                /// <summary>
                /// <para>The remote mount directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("RemoteDirectory")]
                [Validation(Required=false)]
                public string RemoteDirectory { get; set; }

                /// <summary>
                /// <para>The array of the node on which the file system is mounted.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public GetClusterVolumesResponseBodyVolumesVolumeInfoRoles Roles { get; set; }
                public class GetClusterVolumesResponseBodyVolumesVolumeInfoRoles : TeaModel {
                    [NameInMap("RoleInfo")]
                    [Validation(Required=false)]
                    public List<GetClusterVolumesResponseBodyVolumesVolumeInfoRolesRoleInfo> RoleInfo { get; set; }
                    public class GetClusterVolumesResponseBodyVolumesVolumeInfoRolesRoleInfo : TeaModel {
                        /// <summary>
                        /// <para>The type of the node on which the file system is mounted. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Compute: compute node</description></item>
                        /// <item><description>Manager: management node</description></item>
                        /// <item><description>Login: logon node</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Compute</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e754****</para>
                /// </summary>
                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public string VolumeId { get; set; }

                /// <summary>
                /// <para>The address of the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e754****-kal90.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("VolumeMountpoint")]
                [Validation(Required=false)]
                public string VolumeMountpoint { get; set; }

                /// <summary>
                /// <para>The storage protocol type of the file system. Valid values:</para>
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
                /// <para>The type of the file system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NAS</description></item>
                /// </list>
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
