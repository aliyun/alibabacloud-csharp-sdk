// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateComponentIndexRequest : TeaModel {
        /// <summary>
        /// <para>The metadata, which is used to store information such as remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{       &quot;description&quot;: &quot;set number of shards to one&quot;   }</para>
        /// </summary>
        [NameInMap("_meta")]
        [Validation(Required=false)]
        public Dictionary<string, object> Meta { get; set; }

        /// <summary>
        /// <para>The composable template information.</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public CreateComponentIndexRequestTemplate Template { get; set; }
        public class CreateComponentIndexRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The aliases configuration of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("aliases")]
            [Validation(Required=false)]
            public Dictionary<string, object> Aliases { get; set; }

            /// <summary>
            /// <para>The mappings configuration of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ 			&quot;properties&quot;: { 				&quot;@timestamp&quot;: { 					&quot;type&quot;: &quot;date&quot; 				} 			} 		}</para>
            /// </summary>
            [NameInMap("mappings")]
            [Validation(Required=false)]
            public Dictionary<string, object> Mappings { get; set; }

            /// <summary>
            /// <para>The settings configuration of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ 			&quot;index.number_of_replicas&quot;: 0 		}</para>
            /// </summary>
            [NameInMap("settings")]
            [Validation(Required=false)]
            public Dictionary<string, object> Settings { get; set; }

        }

    }

}
