// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetTableFieldsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58113A95-1858-5674-87E5-192AEE6FD9DD</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;classic&quot;: &quot;VARCHAR&quot;,
        ///         &quot;address&quot;: &quot;CHAR&quot;,
        ///         &quot;string&quot;: &quot;STRING&quot;,
        ///         &quot;price&quot;: &quot;DECIMAL&quot;,
        ///         &quot;name&quot;: &quot;STRING&quot;,
        ///         &quot;id&quot;: &quot;INT&quot;,
        ///         &quot;tint&quot;: &quot;TINYINT&quot;,
        ///         &quot;home&quot;: &quot;DECIMAL&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
