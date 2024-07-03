// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecLogDeliveriesResponseBody : TeaModel {
        /// <summary>
        /// The configurations of API security log subscription.
        /// </summary>
        [NameInMap("DeliveryConfigs")]
        [Validation(Required=false)]
        public List<DescribeApisecLogDeliveriesResponseBodyDeliveryConfigs> DeliveryConfigs { get; set; }
        public class DescribeApisecLogDeliveriesResponseBodyDeliveryConfigs : TeaModel {
            /// <summary>
            /// The type of the log subscription. Valid values:
            /// 
            /// *   **risk**: risk information.
            /// *   **event**: attack event information.
            /// *   **asset**: asset information.
            /// </summary>
            [NameInMap("AssertKey")]
            [Validation(Required=false)]
            public string AssertKey { get; set; }

            /// <summary>
            /// The ID of the region where logs are stored.
            /// </summary>
            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            /// <summary>
            /// The name of the Logstore in Simple Log Service.
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// The name of the project in Simple Log Service.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// The status of API security log subscription. Valid values:
            /// 
            /// *   **true**: enabled.
            /// *   **false**: disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
