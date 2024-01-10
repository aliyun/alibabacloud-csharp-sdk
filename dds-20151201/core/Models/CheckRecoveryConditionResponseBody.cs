// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckRecoveryConditionResponseBody : TeaModel {
        /// <summary>
        /// The instance ID
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// Indicates whether the data of the instance can be restored. Valid values:
        /// 
        /// *   **true**: The data of the instance can be restored.
        /// *   **false**: The data of the instance cannot be restored.
        /// </summary>
        [NameInMap("IsValid")]
        [Validation(Required=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
