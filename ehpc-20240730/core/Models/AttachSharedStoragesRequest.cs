// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class AttachSharedStoragesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The information about the shared storage resources that you want to attach to the cluster.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<AttachSharedStoragesRequestSharedStorages> SharedStorages { get; set; }
        public class AttachSharedStoragesRequestSharedStorages : TeaModel {
            /// <summary>
            /// <para>The ID of the file system to be attached.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0bd504b0**</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The storage location of the file system to be attached. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OnPremise: The file system is deployed on a hybrid cloud.</description></item>
            /// <item><description>PublicCloud: The file system is deployed on a public cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PublicCloud</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The local mount directory of the file system that you want to attach.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("MountDirectory")]
            [Validation(Required=false)]
            public string MountDirectory { get; set; }

            /// <summary>
            /// <para>The attaching options of the file system to be attached. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>\-t nfs -o vers=3,nolock,proto=tcp,noresvport</description></item>
            /// <item><description>\-t nfs -o vers=4.0,noresvport</description></item>
            /// </list>
            /// <para>Default value:-t nfs -o vers=3,nolock,proto=tcp,noresvport</para>
            /// <remarks>
            /// <para> The v3 version is recommended for higher performance if multiple Elastic Compute Service (ECS) instances do not edit the same file at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>-t nfs -o vers=3,nolock,proto=tcp,noresvport</para>
            /// </summary>
            [NameInMap("MountOptions")]
            [Validation(Required=false)]
            public string MountOptions { get; set; }

            /// <summary>
            /// <para>The address of the mount point of the file system to be attached.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0bd504b***-ngq26.cn-hangzhou.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("MountTarget")]
            [Validation(Required=false)]
            public string MountTarget { get; set; }

            /// <summary>
            /// <para>The protocol type of the file system to be attached. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NFS</description></item>
            /// <item><description>SMB</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The storage directory of the file system. You can mount any directory in the file system to the specified cluster directory.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/testehpc</para>
            /// </summary>
            [NameInMap("StorageDirectory")]
            [Validation(Required=false)]
            public string StorageDirectory { get; set; }

            /// <summary>
            /// <para>The type of the file system to be attached. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nas</description></item>
            /// <item><description>cpfs</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nas</para>
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

        }

    }

}
