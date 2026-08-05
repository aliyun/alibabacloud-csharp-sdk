// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ModifyOfflineTaskLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1-2-3-4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;network&quot;: {
        ///     &quot;publicEs&quot;: {
        ///       &quot;enabled&quot;: true,
        ///       &quot;whiteIpGroup&quot;: [
        ///         {
        ///           &quot;groupName&quot;: &quot;kevintest&quot;,
        ///           &quot;ips&quot;: [
        ///             &quot;1.2.3.4&quot;,
        ///             &quot;1.2.4.3&quot;
        ///           ]
        ///         }
        ///       ]
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
