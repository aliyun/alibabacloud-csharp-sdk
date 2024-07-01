// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class RemindQuotaApplicationApprovalRequest : TeaModel {
        /// <summary>
        /// The quota application ID.
        /// 
        /// For more information about how to obtain the ID of a quota application, see [ListQuotaApplications](https://help.aliyun.com/document_detail/440568.html).
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

    }

}
