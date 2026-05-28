// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentExplorer20260317.Models
{
    public class GetSkillContentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// <h2>name: alibabacloud-find-skills
        /// description: &quot;Search for official Alibaba Cloud Agent Skills based on user requirements&quot;</h2>
        /// <para>Agent Skill Body Content Here</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764D64D-5262-55DA-BDBF-1F949B1B34F7</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
