// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListExecutorsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for querying executors.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The current page number.<br>Start value: 1<br>Default value: 1<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. Default value: 50. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
