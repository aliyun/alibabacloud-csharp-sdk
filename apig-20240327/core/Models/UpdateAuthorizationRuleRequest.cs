// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAuthorizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The new list of authorized resources. In the MCP tool scenario, this is a collection of tool names. If an empty array is provided, the ErrInvalidParameterWithEmpty error is returned.</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

    }

}
