// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Submit business parameters as described in this operation. The body parameters of public APIs are mapped to backend wrappers by the gateway. Do not mix them with direct backend body wrappers.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

    }

}
