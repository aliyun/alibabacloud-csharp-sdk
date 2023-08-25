// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastEipAddressRequest : TeaModel {
        /// <summary>
        /// The ID of the Anycast EIP.
        /// 
        /// >  You must specify at least one of **Ip** and **AnycastId**.
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// The ID of the cloud resource with which the Anycast EIP is associated.
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// The IP address of the Anycast EIP.
        /// 
        /// >  You must specify at least one of **Ip** and **AnycastId**.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

    }

}
