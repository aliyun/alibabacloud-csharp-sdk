// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TracingConfig : TeaModel {
        /// <summary>
        /// <para>The tracing parameters. The parameter is a map[string]string, where the key is &quot;endpoint&quot; and the value is your Tracing Analysis internal network endpoint. Example: endpoint: <a href="http://tracing-analysis-dc-hz.aliyuncs.com/adapt_xxx/api/otlp/traces">http://tracing-analysis-dc-hz.aliyuncs.com/adapt_xxx/api/otlp/traces</a>.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// <para>The Tracing Analysis protocol type. Currently, only Jaeger is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jaeger</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
