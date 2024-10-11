// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class VerifyRankingSystemRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;userFeatures&quot;: &quot;a:c,d:b&quot;,
        ///   &quot;itemFeatures&quot;: &quot;a:1,b:2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
