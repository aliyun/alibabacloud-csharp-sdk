// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerSophonPlaybookRequest : TeaModel {
        /// <summary>
        /// The name of the command that you want to trigger.
        /// 
        /// >  You can call the [DescribeSophonCommands](~~DescribeSophonCommands~~) operation to query the command name.
        /// </summary>
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        /// <summary>
        /// The input parameters of the command or playbook that you want to trigger.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputParams")]
        [Validation(Required=false)]
        public string InputParams { get; set; }

        /// <summary>
        /// The custom ID. If you do not specify this parameter when the playbook is triggered, a random ID is generated for fault locating and troubleshooting.
        /// </summary>
        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

        /// <summary>
        /// The task type. Valid values:
        /// 
        /// *   **command**
        /// *   **playbook**
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// The UUID of the playbook.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~)operation to query the playbook UUID.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
