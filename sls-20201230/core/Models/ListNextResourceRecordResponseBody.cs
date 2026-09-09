// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListNextResourceRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resource records.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ResourceRecord> Items { get; set; }

        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t7F6JzTNNTjkq2tRBH8hR0a_NcuVYQWjbVwdFeuFhkylsUhrDl0JSofT5mrbI0oV&quot;</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The total number of records that match the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>245</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
