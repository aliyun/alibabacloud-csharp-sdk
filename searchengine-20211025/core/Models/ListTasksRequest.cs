// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp that indicates the end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690423741577</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687238865434</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
