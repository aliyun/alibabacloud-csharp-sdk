// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests.
        /// 
        /// The token can be up to 64 characters in length,
        /// 
        /// For more information, see [Ensure idempotence](~~134212~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The option for returning logs. Valid values:
        /// 
        /// *   None: does not return logs.
        /// *   Stack: returns the logs of the stack. This is the default value.
        /// *   Resource: returns the logs of resources in the stack.
        /// *   All: returns the logs of all resources.
        /// </summary>
        [NameInMap("LogOption")]
        [Validation(Required=false)]
        public string LogOption { get; set; }

        /// <summary>
        /// Specifies whether to return the output parameters of the stack. Valid values:
        /// 
        /// *   Enabled: returns the output parameters. This is the default value.
        /// 
        /// *   Disabled: does not return the output parameters.
        /// 
        /// > The system takes a long period of time to calculate output parameters. If you do not want to query the output parameters, we recommend that you set the OutputOption parameter to Disabled to improve the response speed of the GetStack operation.
        /// </summary>
        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        /// <summary>
        /// The ID of the region in which the stack resides. You can call the [DescribeRegions](~~131035~~) operation to query the most recent list of Alibaba Cloud regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to return the ResourceProgress parameter. Valid values:
        /// 
        /// *   Disabled: does not return the ResourceProgress parameter. This is the default value.
        /// 
        /// *   EnabledIfCreateStack: returns the ResourceProgress parameter only if a stack is created.
        /// 
        /// > A stack is in one of the following states when it is created: CREATE_IN_PROGRESS, CREATE_COMPLETE, CREATE_FAILED, CREATE_ROLLBACK_IN_PROGRESS, CREATE_ROLLBACK_COMPLETE, or CREATE_ROLLBACK_FAILED.
        /// </summary>
        [NameInMap("ShowResourceProgress")]
        [Validation(Required=false)]
        public string ShowResourceProgress { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
