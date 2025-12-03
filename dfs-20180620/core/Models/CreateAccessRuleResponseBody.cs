// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class CreateAccessRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acr-c38028f0-f313-4385-9456-3501b1f5****</para>
        /// </summary>
        [NameInMap("AccessRuleId")]
        [Validation(Required=false)]
        public string AccessRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
