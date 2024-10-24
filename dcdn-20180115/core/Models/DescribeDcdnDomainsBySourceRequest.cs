// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainsBySourceRequest : TeaModel {
        /// <summary>
        /// The list of origin servers. Separate origin servers with commas (,). You can specify a maximum of 20 origin servers. Fuzzy match is not supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

    }

}
