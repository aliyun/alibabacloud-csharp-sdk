// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListContextStoreAPIKeysRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>615dfe7fd00f699ea94d5e63ba564aaf22450858c58f1387cc78f883b2254ab47232ce40fa95d9cb</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
