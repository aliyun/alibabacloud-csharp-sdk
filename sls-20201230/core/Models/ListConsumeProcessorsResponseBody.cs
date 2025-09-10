// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListConsumeProcessorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of consumption processors for offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of consumption processor information.</para>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<ConsumeProcessor> Processors { get; set; }

        /// <summary>
        /// <para>The total number of consumption processors that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
