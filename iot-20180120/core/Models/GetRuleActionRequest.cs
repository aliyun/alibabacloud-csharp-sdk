// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetRuleActionRequest : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("ActionId")]
        [Validation(Required=false)]
        public long? ActionId { get; set; }

        /// <summary>
        /// The rule action ID that you want to query.
        /// 
        /// You can query the rule action ID by using the following methods:
        /// 
        /// *   Call the [CreateRuleAction](~~69586~~) operation and view the **ActionId** parameter in the response.
        /// *   Call the [ListRuleActions](~~69517~~) operation and view the **Id** parameter in the response.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
