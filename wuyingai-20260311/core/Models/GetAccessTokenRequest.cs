// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingAI20260311.Models
{
    public class GetAccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the user in the external system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;user-38764&quot;</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>The ID of the agent template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1600112233445566</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
