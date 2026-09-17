// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The update request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateConnectorRequestBody Body { get; set; }
        public class UpdateConnectorRequestBody : TeaModel {
            /// <summary>
            /// <para>The Connector configuration JSON string. The site value must match the value specified when the Connector was enabled. The organizationId value, if provided, must match the value specified when the Connector was enabled. If apiKey is omitted, the original value is retained. If serviceAccountKeys is provided, it represents the complete updated key collection.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;site&quot;:&quot;global&quot;,&quot;organizationId&quot;:&quot;org-xxxx&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

        }

    }

}
