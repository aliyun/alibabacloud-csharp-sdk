// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ModifyCopilotEmbedConfigRequest : TeaModel {
        /// <summary>
        /// <para>Agent nickname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smartq</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>Embedding ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccd3428c-dd2xxxxxxxxxxxxdffee</para>
        /// </summary>
        [NameInMap("CopilotId")]
        [Validation(Required=false)]
        public string CopilotId { get; set; }

        /// <summary>
        /// <para>Data range.</para>
        /// <remarks>
        /// <para>Notice: The parameter type is jsonString, and only one switch between analysis themes and query resources can be effective. When the all-select switch is true, it takes precedence. It is recommended to pass only one parameter, with other notes</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Map&lt;String,Object&gt; data=new HashMap&lt;&gt;();
        ///         data.put(&quot;allTheme&quot;,true);
        ///         //data.put(&quot;allCube&quot;,true);
        ///         //data.put(&quot;themes&quot;,Lists.newArrayList(&quot;1111&quot;,&quot;22222&quot;));
        ///         //data.put(&quot;llmCubes&quot;,Lists.newArrayList(&quot;33333&quot;,&quot;44444&quot;));
        ///         request.setDataRange(JSON.toJSONString(data));</para>
        /// </summary>
        [NameInMap("DataRange")]
        [Validation(Required=false)]
        public string DataRange { get; set; }

        /// <summary>
        /// <para>Module name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smartq</para>
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

    }

}
