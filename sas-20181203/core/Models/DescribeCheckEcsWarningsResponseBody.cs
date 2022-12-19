// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckEcsWarningsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether you use the free trial of Security Center. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("CanTry")]
        [Validation(Required=false)]
        public string CanTry { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The edition of Security Center that you use. Valid values:
        /// 
        /// *   **1**: Basic edition
        /// *   **2** or **3**: Enterprise edition
        /// *   **5**: Advanced edition
        /// *   **6**: Anti-virus edition
        /// 
        /// >  Both the value 2 and the value 3 indicate the Enterprise edition.
        /// </summary>
        [NameInMap("SasVersion")]
        [Validation(Required=false)]
        public string SasVersion { get; set; }

        /// <summary>
        /// The number of weak passwords that can cause high risks to your assets.
        /// </summary>
        [NameInMap("WeakPasswordCount")]
        [Validation(Required=false)]
        public string WeakPasswordCount { get; set; }

    }

}
