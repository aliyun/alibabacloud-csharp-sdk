// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// The internal endpoint of the instance.
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The instance ID. If the value of the **Amount** parameter is greater than **1**, more than one instance ID is returned. The number of instance IDs that are returned is the same as the value of the Amount parameter. The returned instance IDs are separated by commas (,).
        /// 
        /// For example, if the value of the **Amount** parameter is **3**, three instance IDs are returned. Examples: `rm-uf6wjk5*****1,rm-uf6wjk5*****2,rm-uf6wjk5*****3`
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Indicates that the system performed a dry run.
        /// 
        /// *   The value is fixed as **true**.
        /// *   If the system does not perform a dry run, this parameter is not returned.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Indicates whether the request passed the dry run. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > 
        /// 
        /// *   If the system does not perform a dry run, this parameter is not returned.
        /// 
        /// *   If the request failed the dry run, an error message is returned.
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public bool? DryRunResult { get; set; }

        /// <summary>
        /// The message that indicates whether multiple instances are created.
        /// 
        /// > The parameter is returned only when the value of the **Amount** parameter is greater than 1.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The order ID.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The internal IP address and port number that are used to connect to the instance.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the specified tag is added to the instance. Valid values:
        /// 
        /// *   **true**: The specified tag is added to the instance.
        /// *   **false**: The specified tag fails to be added to the instance.
        /// 
        /// > If you do not add a tag to the instance, this parameter is not returned.
        /// </summary>
        [NameInMap("TagResult")]
        [Validation(Required=false)]
        public bool? TagResult { get; set; }

        /// <summary>
        /// The ID of the task that is run to create multiple instances.
        /// 
        /// *   This parameter is returned only when the value of **Amount** is greater than 1.
        /// *   The **TaskID** parameter cannot be used to query a task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
