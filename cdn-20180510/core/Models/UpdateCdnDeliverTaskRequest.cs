// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class UpdateCdnDeliverTaskRequest : TeaModel {
        /// <summary>
        /// The method that is used to send operations reports. Operations reports are sent to you only by email. The settings must be escaped in JSON.
        /// </summary>
        [NameInMap("Deliver")]
        [Validation(Required=false)]
        public string Deliver { get; set; }

        /// <summary>
        /// The ID of the tracking task that you want to update.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

        /// <summary>
        /// The domain name that you want to track. You can specify up to 500 domain names in each request. Separate multiple domain names with commas (,). If you do not specify a domain name, the task collects data from all domain names that belong to your Alibaba Cloud account.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The name of the tracking task.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The operations reports that are tracked by the task. The data must be escaped in JSON.
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public string Reports { get; set; }

        /// <summary>
        /// The parameters that specify the time interval at which the tracking task sends operations reports. The settings must be escaped in JSON.
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

    }

}
