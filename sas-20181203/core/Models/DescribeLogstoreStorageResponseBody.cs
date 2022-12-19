// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogstoreStorageResponseBody : TeaModel {
        /// <summary>
        /// The name of the dedicated Logstore that is used to store full logs of Security Center. The value is fixed as **sas-log**.
        /// </summary>
        [NameInMap("Logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// The purchased log storage capacity, in GB.
        /// </summary>
        [NameInMap("Preserve")]
        [Validation(Required=false)]
        public long? Preserve { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of days during which logs can be retained. The value is fixed as **180**, which indicates that logs can be retained for 180 days.
        /// 
        /// >  You are not allowed to change the value of this parameter.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The used log storage capacity, in GB.
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

        /// <summary>
        /// The name of the dedicated Project that is used to store full logs of Security Center.
        /// </summary>
        [NameInMap("UserProject")]
        [Validation(Required=false)]
        public string UserProject { get; set; }

    }

}
