// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListPartitionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The partitions.</para>
        /// </summary>
        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<Partition> Partitions { get; set; }

    }

}
