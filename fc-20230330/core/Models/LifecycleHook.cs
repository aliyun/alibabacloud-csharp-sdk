// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class LifecycleHook : TeaModel {
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The handler of the hook. The definition is similar to that of a request handler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index.initializer</para>
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// <para>The timeout period of the hook. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
