// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the components. The value is a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;actions&quot;: [
        ///             {
        ///                 &quot;description&quot;: &quot;mysql component&quot;,
        ///                 &quot;name&quot;: &quot;storeIdb&quot;,
        ///                 &quot;parameters&quot;: [
        ///                     {
        ///                         &quot;description&quot;: &quot;update the mysql db&quot;,
        ///                         &quot;name&quot;: &quot;updateSql&quot;,
        ///                         &quot;required&quot;: false
        ///                     }
        ///                 ]
        ///             }
        ///         ],
        ///         &quot;basic&quot;: {
        ///             &quot;description&quot;: &quot;mysq sql component for 5.6&quot;,
        ///             &quot;logo&quot;: &quot;<a href="https://img.alicdn.com/tfs/TB1H89IpH3nBKNjSZFMXXaUSFXa-200-200.svg">https://img.alicdn.com/tfs/TB1H89IpH3nBKNjSZFMXXaUSFXa-200-200.svg</a>&quot;,
        ///             &quot;name&quot;: &quot;Mysql&quot;
        ///         }
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string Components { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B0A255B3-495C-56FB-8B6B-DB073F80388A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
