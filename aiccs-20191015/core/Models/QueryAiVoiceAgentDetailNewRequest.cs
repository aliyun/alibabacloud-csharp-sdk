// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailNewRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234***5678</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The ID of the branch. If you do not specify this parameter, the active branch is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <para>The ID of the version. If you do not specify this parameter, the system uses the latest published version for the specified branch. You must specify BranchId when you use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
