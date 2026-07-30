// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class PluginAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<PluginAnalysisResponseBodyResult> Result { get; set; }
        public class PluginAnalysisResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The plug-in description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plugin description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The plug-in version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.17.0</para>
            /// </summary>
            [NameInMap("elasticsearchVersion")]
            [Validation(Required=false)]
            public string ElasticsearchVersion { get; set; }

            /// <summary>
            /// <para>The plug-in name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plugin_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The security policy of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("securityPolicy")]
            [Validation(Required=false)]
            public string SecurityPolicy { get; set; }

            /// <summary>
            /// <para>The plug-in version.</para>
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
