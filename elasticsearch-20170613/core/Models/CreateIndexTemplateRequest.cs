// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateIndexTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E1136AE9-4E49-4585-9358-6FDD2A6D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataStream")]
        [Validation(Required=false)]
        public bool? DataStream { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>policy-1</para>
        /// </summary>
        [NameInMap("ilmPolicy")]
        [Validation(Required=false)]
        public string IlmPolicy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("indexPatterns")]
        [Validation(Required=false)]
        public List<string> IndexPatterns { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index-template</para>
        /// </summary>
        [NameInMap("indexTemplate")]
        [Validation(Required=false)]
        public string IndexTemplate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public CreateIndexTemplateRequestTemplate Template { get; set; }
        public class CreateIndexTemplateRequestTemplate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;mydata&quot;: {}}</para>
            /// </summary>
            [NameInMap("aliases")]
            [Validation(Required=false)]
            public string Aliases { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;properties&quot;: {&quot;created_at&quot;: {&quot;type&quot;: &quot;date&quot;,&quot;format&quot;: &quot;EEE MMM dd HH:mm:ss Z yyyy&quot;},&quot;host_name&quot;: {&quot;type&quot;: &quot;keyword&quot;}}}</para>
            /// </summary>
            [NameInMap("mappings")]
            [Validation(Required=false)]
            public string Mappings { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;index.refresh_interval&quot;:&quot;1s&quot;}</para>
            /// </summary>
            [NameInMap("settings")]
            [Validation(Required=false)]
            public string Settings { get; set; }

        }

    }

}
