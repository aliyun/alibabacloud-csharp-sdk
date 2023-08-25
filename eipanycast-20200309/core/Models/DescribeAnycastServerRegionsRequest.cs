// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastServerRegionsRequest : TeaModel {
        /// <summary>
        /// The access area from which you use the Anycast EIP to communicate with the Internet.
        /// 
        /// Set the value to **international**, which specifies the regions outside the Chinese mainland.
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

    }

}
