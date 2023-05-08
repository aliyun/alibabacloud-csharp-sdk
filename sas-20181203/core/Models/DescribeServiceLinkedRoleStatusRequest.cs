// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeServiceLinkedRoleStatusRequest : TeaModel {
        /// <summary>
        /// The service-linked role. Default value: **AliyunServiceRoleForSas**. Valid values:
        /// 
        /// *   **AliyunServiceRoleForSas**: the service-linked role of Security Center. Security Center assumes this role to access the resources of other cloud services within your account.
        /// *   **AliyunServiceRoleForSasCspm**: the service-linked role of Security Center-CSPM. Security Center-CSPM assumes this role to access the resources of other cloud services within your account.
        /// </summary>
        [NameInMap("ServiceLinkedRole")]
        [Validation(Required=false)]
        public string ServiceLinkedRole { get; set; }

    }

}
