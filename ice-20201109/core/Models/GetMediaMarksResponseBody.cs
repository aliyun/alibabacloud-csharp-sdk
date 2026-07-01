// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaMarksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The queried marks.</para>
        /// <list type="bullet">
        /// <item><description>The value is in the JSONArray format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///  {
        ///  &quot;MarkStartTime&quot;: &quot;12.1&quot;,
        ///  &quot;MarkEndTime&quot;: &quot;12.2&quot;,
        ///  &quot;MarkTag&quot;: &quot;tag-1&quot;,
        ///  &quot;MarkContent&quot;: &quot;content-1&quot;,
        ///  &quot;MarkStatus&quot;: &quot;a&quot;
        ///  },
        ///  {
        ///  &quot;MarkStartTime&quot;: &quot;12.3&quot;,
        ///  &quot;MarkEndTime&quot;: &quot;12.4&quot;,
        ///  &quot;MarkTag&quot;: &quot;tag-2&quot;,
        ///  &quot;MarkContent&quot;: &quot;content-2&quot;,
        ///  &quot;MarkStatus&quot;: &quot;online&quot;
        ///  }
        /// ]</para>
        /// </summary>
        [NameInMap("MediaMarks")]
        [Validation(Required=false)]
        public string MediaMarks { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
