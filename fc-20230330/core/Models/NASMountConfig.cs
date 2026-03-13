// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class NASMountConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use the Transport Layer Security (TLS) protocol to secure data transmission. Note: Only General-purpose NAS supports transmission encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableTLS")]
        [Validation(Required=false)]
        public bool? EnableTLS { get; set; }

        /// <summary>
        /// <para>The local mount directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/test</para>
        /// </summary>
        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>The address of a NAS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>***-uni85.cn-hangzhou.nas.com:/</para>
        /// </summary>
        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

    }

}
