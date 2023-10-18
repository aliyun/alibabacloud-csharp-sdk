// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeHighDefinitionMonitorLogAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance whose fine-grained monitoring configurations you want to query.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of instance for which you want to query fine-grained monitoring. Only **EIP** may be returned.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The name of the project.
        /// </summary>
        [NameInMap("LogProject")]
        [Validation(Required=false)]
        public string LogProject { get; set; }

        /// <summary>
        /// The name of the Logstore.
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the operation is performed. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
