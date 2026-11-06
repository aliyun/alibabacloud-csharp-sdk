// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentRequest : TeaModel {
        /// <summary>
        /// <para>If omitted, the current definition is retrieved. If a published version is specified, the corresponding snapshot and the fixed versions of official skills and suite artifacts are retrieved. If the current unpublished version is specified, the draft is returned without fixed artifact versions. This is not the POP system parameter Version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public int? AgentVersion { get; set; }

        /// <summary>
        /// <para>The name of the skill to retrieve.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-skill</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
