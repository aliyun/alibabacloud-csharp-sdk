// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class EnableDasProRequest : TeaModel {
        /// <summary>
        /// The database instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The storage duration of SQL Explorer data. Unit: day. Default value: **30**. Valid values:
        /// 
        /// *   **30**
        /// *   **180**
        /// *   **365**
        /// *   **1095**
        /// *   **1825**
        /// </summary>
        [NameInMap("SqlRetention")]
        [Validation(Required=false)]
        public int? SqlRetention { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account that is used to create the database instance.
        /// 
        /// >  This parameter is optional. The system can automatically obtain the account ID based on the value of InstanceId when you call this operation.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
