// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAsyncSqlRequest : TeaModel {
        /// <summary>
        /// <para>The number of results to return per page. The maximum value is 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public int? Line { get; set; }

        /// <summary>
        /// <para>The offset for paginated results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

    }

}
