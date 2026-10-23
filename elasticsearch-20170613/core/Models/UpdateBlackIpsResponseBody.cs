// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateBlackIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The updated access blacklist information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateBlackIpsResponseBodyResult Result { get; set; }
        public class UpdateBlackIpsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of IP addresses in the access blacklist of the Elasticsearch instance.</para>
            /// </summary>
            [NameInMap("esIPBlacklist")]
            [Validation(Required=false)]
            public List<string> EsIPBlacklist { get; set; }

        }

    }

}
