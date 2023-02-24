// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeAccountKmsStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of KMS within your Alibaba cloud account. Valid values:
        /// 
        /// *   Enabled: KMS is enabled.
        /// 
        /// *   NotEnabled: KMS is disabled.
        /// 
        /// *   InDebt: Your account is overdue, and KMS stops providing services.
        /// 
        /// > If your Alibaba Cloud account is overdue, top up your account at the earliest opportunity to avoid impacts on your services.
        /// 
        /// *   Suspended: KMS is suspended.
        /// </summary>
        [NameInMap("AccountStatus")]
        [Validation(Required=false)]
        public string AccountStatus { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
