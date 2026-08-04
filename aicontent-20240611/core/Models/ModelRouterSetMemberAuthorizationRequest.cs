// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterSetMemberAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization configuration (JSON string, overwrite mode): {&quot;model_ids&quot;:[...],&quot;group_ids&quot;:[&quot;mg_xxx&quot;]}. The internal key names use a fixed underscore style and are not converted to the camelCase convention used by the API. If this field is specified together with allowedModels, this field takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model_ids&quot;:[],&quot;group_ids&quot;:[&quot;mg_qwen_49&quot;]}</para>
        /// </summary>
        [NameInMap("allowedModelGroupConfig")]
        [Validation(Required=false)]
        public string AllowedModelGroupConfig { get; set; }

        /// <summary>
        /// <para>The legacy authorization field (comma-separated numeric model IDs). This field is retained during the canary release of group-based authorization: tenants that have not enabled the grouping feature continue to use this field. If this field is specified together with allowedModelGroupConfig, the latter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101,102,103</para>
        /// </summary>
        [NameInMap("allowedModels")]
        [Validation(Required=false)]
        public string AllowedModels { get; set; }

    }

}
