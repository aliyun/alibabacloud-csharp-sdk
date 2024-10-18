// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class SharedStorageTemplate : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>008b63****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("MountDirectory")]
        [Validation(Required=false)]
        public string MountDirectory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-t nfs -o vers=3,nolock,noresvport</para>
        /// </summary>
        [NameInMap("MountOptions")]
        [Validation(Required=false)]
        public string MountOptions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>008b****-sihc.cn-hangzhou.extreme.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("NASDirectory")]
        [Validation(Required=false)]
        public string NASDirectory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NFS</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

    }

}
