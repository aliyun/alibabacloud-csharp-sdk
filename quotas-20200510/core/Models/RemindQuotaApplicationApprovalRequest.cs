// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class RemindQuotaApplicationApprovalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the quota application.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/440568.html">ListQuotaApplications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>219f1ff6-6205-495f-bda7-90d2fe945e****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

    }

}
