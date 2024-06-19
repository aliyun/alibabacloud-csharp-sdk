// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyActiveOperationTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the O\\&M task. Separate multiple IDs with commas (,).
        /// 
        /// > You can call the [DescribeActiveOperationTask](https://help.aliyun.com/document_detail/197387.html) operation to query the ID of an O\\&M task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The scheduled switchover time to be specified. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > The time cannot be later than the latest operation time. You can call the [DescribeActiveOperationTask](https://help.aliyun.com/document_detail/197387.html) operation to obtain the latest operation time, which is the value of the **Deadline** parameter in the response.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

    }

}
