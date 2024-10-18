// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSharedStoragesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6757FA4-8FED-4602-B7F5-3550C084****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the attached shared storage.</para>
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<ListSharedStoragesResponseBodySharedStorages> SharedStorages { get; set; }
        public class ListSharedStoragesResponseBodySharedStorages : TeaModel {
            /// <summary>
            /// <para>The ID of the attached file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08c7f4b***</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The protocol used by the attached file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nfs3</description></item>
            /// <item><description>nfs4</description></item>
            /// <item><description>cpfs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nfs4</para>
            /// </summary>
            [NameInMap("FileSystemProtocol")]
            [Validation(Required=false)]
            public string FileSystemProtocol { get; set; }

            /// <summary>
            /// <para>The type of the attached file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nas</description></item>
            /// <item><description>cpfs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nas</para>
            /// </summary>
            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            /// <summary>
            /// <para>The mount information.</para>
            /// </summary>
            [NameInMap("MountInfo")]
            [Validation(Required=false)]
            public List<ListSharedStoragesResponseBodySharedStoragesMountInfo> MountInfo { get; set; }
            public class ListSharedStoragesResponseBodySharedStoragesMountInfo : TeaModel {
                /// <summary>
                /// <para>The local mount directory of the attached file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("MountDirectory")]
                [Validation(Required=false)]
                public string MountDirectory { get; set; }

                /// <summary>
                /// <para>The mount options for the attached file system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\-t nfs -o vers=3,nolock,proto=tcp,noresvport</description></item>
                /// <item><description>\-t nfs -o vers=4.0,noresvport</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>-t nfs -o vers=4.0,noresvport</para>
                /// </summary>
                [NameInMap("MountOptions")]
                [Validation(Required=false)]
                public string MountOptions { get; set; }

                /// <summary>
                /// <para>The mount target of the attached file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0bd504b***-ngq26.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("MountTarget")]
                [Validation(Required=false)]
                public string MountTarget { get; set; }

                /// <summary>
                /// <para>The protocol used by the mount target of the attached file system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>nfs3</description></item>
                /// <item><description>nfs4</description></item>
                /// <item><description>cpfs</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>nfs3</para>
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// <para>The storage directory of the attached file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/testehpc</para>
                /// </summary>
                [NameInMap("StorageDirectory")]
                [Validation(Required=false)]
                public string StorageDirectory { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
