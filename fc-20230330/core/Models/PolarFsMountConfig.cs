// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PolarFsMountConfig : TeaModel {
        /// <summary>
        /// <para>The additional mount parameter settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--skip-delete-rows-check=false  --skip-dir-nlink=0</para>
        /// </summary>
        [NameInMap("extraOptions")]
        [Validation(Required=false)]
        public string ExtraOptions { get; set; }

        /// <summary>
        /// <para>The PolarFS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The local mount directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/polarfs</para>
        /// </summary>
        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>The read-only mount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// <para>The PolarFS directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/share</para>
        /// </summary>
        [NameInMap("remoteDir")]
        [Validation(Required=false)]
        public string RemoteDir { get; set; }

    }

}
