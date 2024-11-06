// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainsBySourceRequest : TeaModel {
        /// <summary>
        /// <para>The list of origin servers. Separate origin servers with commas (,). You can specify a maximum of 20 origin servers. Fuzzy match is not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.org</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

    }

}
