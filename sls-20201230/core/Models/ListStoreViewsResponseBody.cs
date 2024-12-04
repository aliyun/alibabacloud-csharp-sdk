// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListStoreViewsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of returned datasets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The dataset names.</para>
        /// </summary>
        [NameInMap("storeviews")]
        [Validation(Required=false)]
        public List<string> Storeviews { get; set; }

        /// <summary>
        /// <para>The total number of datasets in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
