// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class LifecycleHook : TeaModel {
        /// <summary>
        /// <para>The callback command for the function lifecycle initialization phase. The handler and command parameters for the lifecycle hook execution entry point cannot be configured at the same time. Only one can take effect. Configuring both produces an error.</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The execution entry point of the hook, similar in meaning to the handler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index.initializer</para>
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// <para>The timeout period of the hook, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
