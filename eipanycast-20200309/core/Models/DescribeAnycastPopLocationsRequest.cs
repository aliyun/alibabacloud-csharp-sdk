// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastPopLocationsRequest : TeaModel {
        /// <summary>
        /// The access area of the Anycast elastic IP address (EIP).
        /// 
        /// Set the value to **international**, which specifies the areas outside the Chinese mainland.
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

    }

}
