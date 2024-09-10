// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceCriteriaRequest : TeaModel {
        /// <summary>
        /// The ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to query the account ID.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public string ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The value of the search condition. Fuzzy match is supported.
        /// 
        /// >  You can specify the name, ID, public IP address, private IP address, component, port, or IP address of an exposed asset.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
