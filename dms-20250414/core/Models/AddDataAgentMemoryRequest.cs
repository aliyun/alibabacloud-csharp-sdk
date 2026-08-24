// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AddDataAgentMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The memory content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Diamond pricing analysis requires examining the skewness and outliers of the distribution of each feature.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description>If MemFrom is set to session, FromId indicates the session ID.</description></item>
        /// <item><description>If MemFrom is set to user, FromId indicates the RAM user ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2037**********23</para>
        /// </summary>
        [NameInMap("FromId")]
        [Validation(Required=false)]
        public string FromId { get; set; }

        /// <summary>
        /// <para>The memory label. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>fact_specifications: fact definitions.</description></item>
        /// <item><description>task_constraints: node constraints.</description></item>
        /// <item><description>execution_config: execution configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fact_specifications</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The memory source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>session: generated from a session.</description></item>
        /// <item><description>user: edited by a user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("MemFrom")]
        [Validation(Required=false)]
        public string MemFrom { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// <list type="bullet">
        /// <item><description>Note: This parameter is deprecated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fc5ice**********ac6e</para>
        /// </summary>
        [NameInMap("SessionUuid")]
        [Validation(Required=false)]
        public string SessionUuid { get; set; }

    }

}
