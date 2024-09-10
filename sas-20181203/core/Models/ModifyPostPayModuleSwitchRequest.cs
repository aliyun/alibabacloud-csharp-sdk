// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPostPayModuleSwitchRequest : TeaModel {
        /// <summary>
        /// The ID of the pay-as-you-go instance. This parameter is required.
        /// 
        /// >  You can call the [DescribeVersionConfig](~DescribeVersionConfig~) operation to obtain the ID.
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// The switch status of the pay-as-you-go module. The value is a JSON string. Valid values:
        /// 
        /// *   Key:
        /// 
        ///     *   **VUL**: vulnerability fixing module
        ///     *   **CSPM**: cloud service configuration check module
        ///     *   **AGENTLESS**: agentless detection module
        ///     *   **SERVERLESS**: serverless asset module
        /// 
        /// *   Value: A value of 0 specifies disabled. A value of 1 specifies enabled.
        /// 
        /// >  If you do not specify a value for a module, the original value of the module is retained.
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

    }

}
