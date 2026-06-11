// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListMemoryStoresRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return. The maximum value is 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the memory store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qianyi_test_1</para>
        /// </summary>
        [NameInMap("memoryStoreName")]
        [Validation(Required=false)]
        public string MemoryStoreName { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
