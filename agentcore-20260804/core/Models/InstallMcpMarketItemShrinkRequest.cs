// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class InstallMcpMarketItemShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The MCP configuration submitted when installing the template. The configuration must conform to the input schema of the template.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The reserved query request identifier. The console backend does not read this parameter and does not provide idempotency guarantees for deduplication or restoring original results based on this identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The template version to be installed. You can call GetMcpMarketItem to query available versions.</para>
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
