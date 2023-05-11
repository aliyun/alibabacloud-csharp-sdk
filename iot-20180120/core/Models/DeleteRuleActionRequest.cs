// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeleteRuleActionRequest : TeaModel {
        /// <summary>
        /// The identifier of the rule action that you want to delete.
        /// 
        /// After you call the [CreateRuleAction](~~69586~~) operation to create a rule action, the rule action ID is returned. You can call the [ListRuleActions](~~69517~~) operation to view the rule action ID.
        /// </summary>
        [NameInMap("ActionId")]
        [Validation(Required=false)]
        public long? ActionId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
