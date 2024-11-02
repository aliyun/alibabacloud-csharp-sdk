// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class QueryTreeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about the playbook. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;playbook&quot;: {
        ///             &quot;active&quot;: false,
        ///             &quot;displayName&quot;: &quot;test_playbook&quot;,
        ///             &quot;playbookUuid&quot;: &quot;09a20455-3d3a-424c-a1df-xxxxxx&quot;
        ///         }
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public string Playbooks { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF2ECA2D-D8E6-5021-BF5C-19DD6D52C5B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
