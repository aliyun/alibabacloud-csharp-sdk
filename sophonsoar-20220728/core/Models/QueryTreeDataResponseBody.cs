// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class QueryTreeDataResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of playbooks in JSON string format. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>active</b>: Indicates whether the playbook is active. A value of <b>true</b> means the playbook is active. A value of <b>false</b> means the playbook is inactive.</para>
        /// </description></item>
        /// <item><description><para><b>displayName</b>: The name of the playbook.</para>
        /// </description></item>
        /// <item><description><para><b>playbookUuid</b>: The UUID of the playbook.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The ID of the request. Alibaba Cloud generates this unique ID for each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF2ECA2D-D8E6-5021-BF5C-19DD6D52C5B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
