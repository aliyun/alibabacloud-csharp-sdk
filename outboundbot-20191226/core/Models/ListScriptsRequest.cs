// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The NLU robot engine.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is left empty, small model scenarios are queried.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to Prompts, the text input mode under large model scenarios is queried.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to SSE_FUNCTION, the function computing mode under large model scenarios is queried.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to BeeBot, the workflow configuration mode under large model scenarios is queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prompts</para>
        /// </summary>
        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The script name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Course satisfaction follow-up</para>
        /// </summary>
        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

    }

}
