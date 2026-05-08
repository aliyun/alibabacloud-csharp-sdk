// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListContextStoresRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OCAQV0pBqldexv7EidbIZw==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
