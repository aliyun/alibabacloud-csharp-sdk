// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListContextStoresRequest : TeaModel {
        /// <summary>
        /// <para>The name of the context store used for filtering. Exact match is supported. If this parameter is not specified, no filtering is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <para>The type of the context store used for filtering, such as experience or memory. If this parameter is not specified, no filtering is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experience</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>The maximum number of context stores to return in the current request. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. To retrieve the next page, pass the nextToken value from the previous response. Do not specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The memory data source type used for filtering, such as manual, trajectory, or dataset. If this parameter is not specified, no filtering is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trajectory</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
