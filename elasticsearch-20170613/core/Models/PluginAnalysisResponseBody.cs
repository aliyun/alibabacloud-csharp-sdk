// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class PluginAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<PluginAnalysisResponseBodyResult> Result { get; set; }
        public class PluginAnalysisResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Plugin Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plugin description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Plugin version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.17.0</para>
            /// </summary>
            [NameInMap("elasticsearchVersion")]
            [Validation(Required=false)]
            public string ElasticsearchVersion { get; set; }

            /// <summary>
            /// <para>Plugin Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plugin_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Plugin security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("securityPolicy")]
            [Validation(Required=false)]
            public string SecurityPolicy { get; set; }

            /// <summary>
            /// <para>Plugin Version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.17.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
