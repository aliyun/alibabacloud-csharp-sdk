// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterBatchBindModelGroupRequest : TeaModel {
        /// <summary>
        /// <para>The authorization configuration (JSON string). Internal key names use a fixed underscore style: {&quot;model_ids&quot;:[...],&quot;group_ids&quot;:[&quot;mg_xxx&quot;]}</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model_ids&quot;:[],&quot;group_ids&quot;:[&quot;mg_pro&quot;]}</para>
        /// </summary>
        [NameInMap("allowedModelGroupConfig")]
        [Validation(Required=false)]
        public string AllowedModelGroupConfig { get; set; }

        /// <summary>
        /// <para>The array of department IDs. You can specify 1 to 50 IDs. If more than 50, call this operation in batches.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1001, 1002, 1003]</para>
        /// </summary>
        [NameInMap("clientIdList")]
        [Validation(Required=false)]
        public List<long?> ClientIdList { get; set; }

    }

}
