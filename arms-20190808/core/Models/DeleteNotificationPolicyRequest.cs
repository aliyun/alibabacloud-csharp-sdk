// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteNotificationPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the notification policy.
        /// 
        /// For more information about how to obtain the ID of a notification policy, see [ListNotificationPolicies](https://help.aliyun.com/document_detail/2612375.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
