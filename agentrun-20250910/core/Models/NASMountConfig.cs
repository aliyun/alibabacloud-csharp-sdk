// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class NASMountConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable encryption in transit. This option is supported only for general-purpose NAS.</para>
        /// </summary>
        [NameInMap("enableTLS")]
        [Validation(Required=false)]
        public bool? EnableTLS { get; set; }

        /// <summary>
        /// <para>Specifies the local mount directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/test</para>
        /// </summary>
        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>Specifies the NAS server address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>***-uni85.cn-hangzhou.nas.com:/</para>
        /// </summary>
        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

    }

}
