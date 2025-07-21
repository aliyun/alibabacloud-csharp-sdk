// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchDeleteConsumerAuthorizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The rule IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>car-cus2d1em1hkg7732kuk0</para>
        /// </summary>
        [NameInMap("consumerAuthorizationRuleIds")]
        [Validation(Required=false)]
        public string ConsumerAuthorizationRuleIds { get; set; }

    }

}
