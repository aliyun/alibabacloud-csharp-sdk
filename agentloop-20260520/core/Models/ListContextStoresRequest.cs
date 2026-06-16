// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListContextStoresRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>experience</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
