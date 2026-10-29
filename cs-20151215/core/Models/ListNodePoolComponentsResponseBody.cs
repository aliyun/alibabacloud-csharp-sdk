// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListNodePoolComponentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The node components.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<ListNodePoolComponentsResponseBodyComponents> Components { get; set; }
        public class ListNodePoolComponentsResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>The parameter schema of the node component, including custom parameters and system parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;$schema\&quot;: \&quot;\&quot;,\&quot;properties\&quot;: {}&quot;</para>
            /// </summary>
            [NameInMap("config_schema")]
            [Validation(Required=false)]
            public string ConfigSchema { get; set; }

            /// <summary>
            /// <para>The name of the node component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the node component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.28.9-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results per page. Default value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
