// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnFullDomainsBlockIPConfigRequest : TeaModel {
        /// <summary>
        /// <para>The IP address or CIDR block to query. Separate multiple values with commas (,). You can specify up to 50 IP addresses or CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.10/24</para>
        /// </summary>
        [NameInMap("IPList")]
        [Validation(Required=false)]
        public string IPList { get; set; }

    }

}
