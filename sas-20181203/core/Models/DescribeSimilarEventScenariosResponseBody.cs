// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSimilarEventScenariosResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scenarios in which you can handle the alerts triggered by the same rule or rules of the same type.
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public List<DescribeSimilarEventScenariosResponseBodyScenarios> Scenarios { get; set; }
        public class DescribeSimilarEventScenariosResponseBodyScenarios : TeaModel {
            /// <summary>
            /// The code of the scenario. Valid values: Valid values:
            /// - **default**: the same alert type
            /// - **same_file_content**: the same file content rule
            /// - **same_ip**: the same IP address rule
            /// - **same_url**: the same URL rule
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

    }

}
