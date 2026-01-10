// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class NASMountConfig : TeaModel {
        [NameInMap("enableTLS")]
        [Validation(Required=false)]
        public bool? EnableTLS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/home/test</para>
        /// </summary>
        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>***-uni85.cn-hangzhou.nas.com:/</para>
        /// </summary>
        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

    }

}
