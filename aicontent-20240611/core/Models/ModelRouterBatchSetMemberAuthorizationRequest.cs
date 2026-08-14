// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterBatchSetMemberAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization configuration. This parameter is a required JSON string and uses overwrite mode. Format: {&quot;model_ids&quot;:[...],&quot;group_ids&quot;:[&quot;mg_xxx&quot;]}. Internal key names use a fixed underscore style and are not converted to the camelCase convention of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model_ids&quot;:[],&quot;group_ids&quot;:[&quot;mg_qwen_19&quot;]}</para>
        /// </summary>
        [NameInMap("allowedModelGroupConfig")]
        [Validation(Required=false)]
        public string AllowedModelGroupConfig { get; set; }

        /// <summary>
        /// <para>The list of user IDs. This parameter is required. You can specify 1 to 50 user IDs. If more than 50 user IDs are required, call this operation in batches. All specified users must be direct members of the department.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[30001,30002,30003]</para>
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<long?> UserIdList { get; set; }

    }

}
