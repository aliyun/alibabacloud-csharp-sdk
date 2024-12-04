// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListLogStoresResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The Logstores that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test-1&quot;,&quot;test-2&quot;]</para>
        /// </summary>
        [NameInMap("logstores")]
        [Validation(Required=false)]
        public List<string> Logstores { get; set; }

        /// <summary>
        /// <para>The number of the Logstores that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
