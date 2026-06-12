// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAgentInstanceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The process-level configurations.</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ListAgentInstanceConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListAgentInstanceConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>Ownership of the process-level configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;workspace&quot;: &quot;test-workspace&quot;,&quot;service&quot;: &quot;test-service&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>Type of the process-level configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>apm_biz_trace</para>
            /// </summary>
            [NameInMap("configType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

        }

        /// <summary>
        /// <para>The number of data entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The total number of data entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
