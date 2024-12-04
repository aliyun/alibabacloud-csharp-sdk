// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListSavedSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of saved searches returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The saved searches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;test-1&quot;, &quot;test-2&quot; ]</para>
        /// </summary>
        [NameInMap("savedsearchItems")]
        [Validation(Required=false)]
        public List<SavedSearch> SavedsearchItems { get; set; }

        /// <summary>
        /// <para>The total number of saved searches that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
