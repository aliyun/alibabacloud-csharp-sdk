// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CacheInfo : TeaModel {
        /// <summary>
        /// <para>The mount point address of the datasource for service registration in the cache service, such as an OSS Bucket path or a CPFS path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://your-bucket.oss-cn-wulanchabu-internal.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("MountPoint")]
        [Validation(Required=false)]
        public string MountPoint { get; set; }

        /// <summary>
        /// <para>The port number that the cache service provides for external access to the datasource. The client must access cached data through this port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

    }

}
