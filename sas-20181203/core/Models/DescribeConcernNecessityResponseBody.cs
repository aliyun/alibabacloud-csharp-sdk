// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeConcernNecessityResponseBody : TeaModel {
        /// <summary>
        /// The priorities to fix the vulnerabilities. Valid values:
        /// 
        /// *   asap: high
        /// *   later: medium
        /// *   nntf: low
        /// </summary>
        [NameInMap("ConcernNecessity")]
        [Validation(Required=false)]
        public List<string> ConcernNecessity { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
