// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListRuleActionsRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. On the **Overview** page in the IoT Platform console, you can view the **ID** of the instance.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page or instance ID is not displayed in the IoT Platform console, you do not need to configure this parameter.
        /// 
        /// For more information about the instance, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// You can log on to the IoT Platform console and go to the details page of the instance that you want to manage. On the instance details page, choose **Rules Engine** > **Data Forwarding** to obtain the rule ID. Alternatively, you can call the [ListRule](~~69486~~) operation to view the value of the **Id** parameter in the response.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
