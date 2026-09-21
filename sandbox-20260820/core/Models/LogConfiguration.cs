// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class LogConfiguration : TeaModel {
        /// <summary>
        /// <para>The name of the Simple Log Service Logstore that receives sandbox runtime logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-runtime</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project that receives sandbox runtime logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-log-cn-hangzhou</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
