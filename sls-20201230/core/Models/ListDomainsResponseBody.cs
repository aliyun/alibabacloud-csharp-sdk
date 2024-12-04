// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of domain names that are returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The domain names.</para>
        /// </summary>
        [NameInMap("domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// <para>The total number of domain names that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
