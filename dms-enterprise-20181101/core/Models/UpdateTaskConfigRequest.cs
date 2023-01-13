// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskConfigRequest : TeaModel {
        /// <summary>
        /// The advanced configuration for the node. The value of this parameter must be a JSON string.
        /// </summary>
        [NameInMap("NodeConfig")]
        [Validation(Required=false)]
        public string NodeConfig { get; set; }

        /// <summary>
        /// The ID of the task node. You can call the [GetTaskInstanceRelation](~~424711~~) operation to query the node ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
