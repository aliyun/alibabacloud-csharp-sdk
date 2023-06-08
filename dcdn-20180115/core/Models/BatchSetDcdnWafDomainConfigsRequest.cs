// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnWafDomainConfigsRequest : TeaModel {
        /// <summary>
        /// Specifies the header that records the IP address to be obtained. If the default header is selected, the value of this parameter is empty. If a custom header is selected, the value of this parameter is the value specified by the user. Separate multiple values with commas (,). You can specify a maximum of five values.
        /// </summary>
        [NameInMap("ClientIpTag")]
        [Validation(Required=false)]
        public string ClientIpTag { get; set; }

        /// <summary>
        /// The protection status of the domain name. Valid values: on, off, and empty string.
        /// 
        /// *   When you add a domain name, the value of this parameter is **on**, and the value of ClientIpTag takes effect, which is empty if the default header is selected and is the value specified by the user if a custom header is selected.
        /// *   When you delete a domain name, the value of this parameter is **off**, and the value of ClientIpTag does not take effect.
        /// *   When you only modify the value of ClientIpTag, the value of DefenseStatus is an empty string.
        /// </summary>
        [NameInMap("DefenseStatus")]
        [Validation(Required=false)]
        public string DefenseStatus { get; set; }

        /// <summary>
        /// The protected domain names for which you want to change the protection status. You can specify up to 50 domain names. Separate multiple domain names with commas (,).
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

    }

}
