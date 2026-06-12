// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListConsumeProcessorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of consume processors returned in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of consume processors.</para>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<ConsumeProcessor> Processors { get; set; }

        /// <summary>
        /// <para>The total number of consume processors that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
