// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailNewRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public long? BranchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public long? VersionId { get; set; }

    }

}
