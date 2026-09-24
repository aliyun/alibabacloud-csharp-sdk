// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailNewRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234***5678</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The branch ID. If this parameter is left empty, the currently active branch is automatically used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <para>The version ID. If this parameter is left empty, the latest published version of the corresponding branch is used. This parameter must be used together with BranchId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
