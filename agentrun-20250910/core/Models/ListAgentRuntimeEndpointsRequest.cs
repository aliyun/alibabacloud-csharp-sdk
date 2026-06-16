// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListAgentRuntimeEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>Filter by endpoint name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-endpoint</para>
        /// </summary>
        [NameInMap("endpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Search mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("searchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

    }

}
