// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAiModelProviderRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the model provider. This parameter is required. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen Cloud / Alibaba Cloud Bailian.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The complete set of AI service IDs to bind to the model provider. If this parameter is not specified, the existing bindings are retained. If an empty array is specified, all bindings are cleared. Duplicate and empty values are normalized.</para>
        /// </summary>
        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public List<string> ServiceIds { get; set; }

    }

}
