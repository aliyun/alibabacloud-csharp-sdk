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
            /// <para>The JSON string of the connector configuration. The site must be the same as when it was enabled. If organizationId is provided, it must be the same as when it was enabled. If apiKey is omitted, the original value is retained. If serviceAccountKeys is provided, it represents the updated complete key collection.</para>
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
