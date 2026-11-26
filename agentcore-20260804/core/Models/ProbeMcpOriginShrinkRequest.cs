// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ProbeMcpOriginShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The scope of the origin server configuration does not exceed that of the creation API. The control fields for this validation only restrict the validation scope and do not extend the origin server onboarding configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

    }

}
