// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UpdateClusterVolumesRequest : TeaModel {
        /// <summary>
        /// <para>The file systems that you want to mount.</para>
        /// </summary>
        [NameInMap("AdditionalVolumes")]
        [Validation(Required=false)]
        public List<UpdateClusterVolumesRequestAdditionalVolumes> AdditionalVolumes { get; set; }
        public class UpdateClusterVolumesRequestAdditionalVolumes : TeaModel {
            /// <summary>
            /// <para>The queue name of the file system to be mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>work</para>
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// <para>The on-premises mount directory of the file system to be mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/ff</para>
            /// </summary>
            [NameInMap("LocalDirectory")]
            [Validation(Required=false)]
            public string LocalDirectory { get; set; }

            /// <summary>
            /// <para>The storage location of the file system to be mounted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OnPremise: The file system is stored in a hybrid cloud.</description></item>
            /// <item><description>PublicCloud: The file system cluster is stored in a public cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PublicCloud</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The remote directory to which the file system is mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            /// <summary>
            /// <para>The array of the nodes to which the file system is mounted.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<UpdateClusterVolumesRequestAdditionalVolumesRoles> Roles { get; set; }
            public class UpdateClusterVolumesRequestAdditionalVolumesRoles : TeaModel {
                /// <summary>
                /// <para>The type of the node to which the file system is mounted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Manager: management node</description></item>
                /// <item><description>Login: logon node</description></item>
                /// <item><description>Compute: compute node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;Compute&quot;]</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The ID of the file system to be mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>extreme-00b88****</para>
            /// </summary>
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            /// <summary>
            /// <para>The mount option of the file system to be mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-t nfs -o vers=3,nolock,noresvport</para>
            /// </summary>
            [NameInMap("VolumeMountOption")]
            [Validation(Required=false)]
            public string VolumeMountOption { get; set; }

            /// <summary>
            /// <para>The endpoint of the mount target of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0088****-sihc.cn-hangzhou.extreme.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            /// <summary>
            /// <para>The protocol type of the file system to be mounted. Valid values:</para>
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
            /// <para>The type of the file system to be mounted. Set the value to NAS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NAS</para>
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
