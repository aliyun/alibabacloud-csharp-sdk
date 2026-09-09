// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListResourceRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The list of resource records.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ResourceRecord> Items { get; set; }

        /// <summary>
        /// <para>The total number of records that match the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>245</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
