// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class UpdateFlowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the connection flow is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The description of the connection flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>新建流程</para>
        /// </summary>
        [NameInMap("FlowDesc")]
        [Validation(Required=false)]
        public string FlowDesc { get; set; }

        /// <summary>
        /// <para>The ID of the connection flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-15550241a1e942c29835</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The name of the connection flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>新建流程</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The template of the connection flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;FormatVersion&quot;: &quot;appflow-2025-07-01&quot;,
        ///   &quot;Nodes&quot;: [</para>
        /// <pre><c> ]
        /// </c></pre>
        /// <para>}</para>
        /// </summary>
        [NameInMap("FlowTemplate")]
        [Validation(Required=false)]
        public string FlowTemplate { get; set; }

        /// <summary>
        /// <para>The version of the connection flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

    }

}
