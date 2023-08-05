// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceDetailRequest : TeaModel {
        /// <summary>
        /// The UUID of the server that is exposed on the Internet.
        /// 
        /// > You can call the [DescribeExposedInstanceList](~~DescribeExposedInstanceList~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
