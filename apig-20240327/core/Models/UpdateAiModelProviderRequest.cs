// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAiModelProviderRequest : TeaModel {
        /// <summary>
        /// <para>The optional default AI service ID. If not empty, it must be a service in the updated association set. Omitting this parameter retains the saved default. An explicit empty string clears the default. A non-empty value sets the default. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>svc-d00000000000000000000</para>
        /// </summary>
        [NameInMap("defaultServiceId")]
        [Validation(Required=false)]
        public string DefaultServiceId { get; set; }

        /// <summary>
        /// <para>The display name of the model provider. This parameter is required and can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen Cloud / Alibaba Cloud Model Studio</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The complete set of AI service IDs to associate with the model provider. If you do not specify this parameter, the existing associations are retained. If you pass an empty array, all associations are cleared. Duplicate and empty values are normalized.</para>
        /// </summary>
        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public List<string> ServiceIds { get; set; }

    }

}
