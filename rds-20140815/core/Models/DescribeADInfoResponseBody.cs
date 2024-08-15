// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeADInfoResponseBody : TeaModel {
        /// <summary>
        /// The DNS information about the AD domain.
        /// </summary>
        [NameInMap("ADDNS")]
        [Validation(Required=false)]
        public string ADDNS { get; set; }

        /// <summary>
        /// The service IP address of the AD domain.
        /// </summary>
        [NameInMap("ADServerIpAddress")]
        [Validation(Required=false)]
        public string ADServerIpAddress { get; set; }

        /// <summary>
        /// The status of the AD domain. Valid values:
        /// 
        /// *   **-1**: The instance is being added to the AD domain.
        /// *   **0**: The instance fails to be added to the AD domain.
        /// *   **1**: The instance is added to the AD domain.
        /// </summary>
        [NameInMap("ADStatus")]
        [Validation(Required=false)]
        public string ADStatus { get; set; }

        /// <summary>
        /// The cause of the error.
        /// </summary>
        [NameInMap("AbnormalReason")]
        [Validation(Required=false)]
        public string AbnormalReason { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The username of the AD domain.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
