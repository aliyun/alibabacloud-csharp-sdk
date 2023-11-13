// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateAsyncTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The details of the asynchronous export task. The value is a JSON string. The field in the value varies with **TaskType**.
        /// 
        /// If **TaskType** is set to **1**, **3**, **4**, **5**, or **6**, the following filed is returned:
        /// 
        /// *   **instanceId**: the ID of the instance. This field is required and must be of the STRING type.
        /// 
        /// If **TaskType** is set to **2**, the following field is returned:
        /// 
        /// *   **domain**: the domain name of the website, which must be of the STRING type. If you do not specify this field, the forwarding rules of all websites are exported.
        /// </summary>
        [NameInMap("TaskParams")]
        [Validation(Required=false)]
        public string TaskParams { get; set; }

        /// <summary>
        /// The type of the asynchronous export task that you want to create. Valid values:
        /// 
        /// *   **1**: the task to export the port forwarding rules of an instance
        /// *   **2**: the task to export the forwarding rules of a website protected by an instance
        /// *   **3**: the task to export the session persistence and health check settings of an instance
        /// *   **4**: the task to export the anti-DDoS mitigation policies of an instance
        /// *   **5**: the task to download the blacklist for destination IP addresses of an instance
        /// *   **6**: the task to download the whitelist for destination IP addresses of an instance
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

    }

}
