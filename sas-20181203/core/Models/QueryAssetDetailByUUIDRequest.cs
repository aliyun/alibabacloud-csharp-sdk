// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryAssetDetailByUUIDRequest : TeaModel {
        /// <summary>
        /// <para>A key-value pair that consists of the user ID and the asset list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;AliUid&quot;: &quot;176618589410****&quot;,
        ///       &quot;UuidList&quot;: [
        ///             &quot;429fe207-3014-40c6-972b-cdff1d7a****&quot;,
        ///             &quot;429fe207-3014-40c6-972b-cdff1d7b****&quot;,
        ///             &quot;429fe207-3014-40c6-972b-cdff1d7c****&quot;
        ///       ]
        /// }</para>
        /// </summary>
        [NameInMap("Requests")]
        [Validation(Required=false)]
        public string Requests { get; set; }

    }

}
