// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceCriteriaRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to obtain the IDs.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public string ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The value of the search condition. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
