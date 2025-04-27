// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UninstallLogstashPluginRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;logstash-input-datahub&quot;, &quot;logstash-input-maxcompute&quot; ]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<string> Body { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
