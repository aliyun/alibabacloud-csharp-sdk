// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class VerifyConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The validation request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public VerifyConnectorRequestBody Body { get; set; }
        public class VerifyConnectorRequestBody : TeaModel {
            /// <summary>
            /// <para>The Connector configuration JSON string to validate. Set site to global or cn. The serviceAccountKeys field must contain at least one item with a serviceAccountKey.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;site&quot;:&quot;global&quot;,&quot;organizationId&quot;:&quot;org-xxxx&quot;,&quot;apiKey&quot;:&quot;ak-xxxx&quot;,&quot;serviceAccountKeys&quot;:[{&quot;name&quot;:&quot;default&quot;,&quot;serviceAccountKey&quot;:&quot;sk-xxxx&quot;}]}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

        }

    }

}
