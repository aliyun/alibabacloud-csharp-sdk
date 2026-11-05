// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMcpTemplateConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The MCP configuration updated based on the specified template version, which must comply with the input schema of the template.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The reserved query request identifier. The current console backend does not read this parameter and does not provide idempotency guarantees such as deduplication or restoring the original processing result based on this identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The template version used for this update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
