// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The Logtail configurations that are returned on the current page.</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<string> Configs { get; set; }

        /// <summary>
        /// <para>The number of Logtail configurations that are returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The total number of Logtail configurations that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
