// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateComponentIndexRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;description&quot;: &quot;set number of shards to one&quot; }</para>
        /// </summary>
        [NameInMap("_meta")]
        [Validation(Required=false)]
        public Dictionary<string, object> Meta { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public UpdateComponentIndexRequestTemplate Template { get; set; }
        public class UpdateComponentIndexRequestTemplate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("aliases")]
            [Validation(Required=false)]
            public Dictionary<string, object> Aliases { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;properties&quot;: { &quot;@timestamp&quot;: { &quot;type&quot;: &quot;date&quot; } } }</para>
            /// </summary>
            [NameInMap("mappings")]
            [Validation(Required=false)]
            public Dictionary<string, object> Mappings { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;index.number_of_replicas&quot;: 0 }</para>
            /// </summary>
            [NameInMap("settings")]
            [Validation(Required=false)]
            public Dictionary<string, object> Settings { get; set; }

        }

    }

}
