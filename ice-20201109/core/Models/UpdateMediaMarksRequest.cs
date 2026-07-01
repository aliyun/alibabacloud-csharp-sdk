// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaMarksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53afdf003a******6a16b5feac6402</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The marks of the media asset.</para>
        /// <para>This parameter is required.</para>
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

    }

}
