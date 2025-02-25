// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSitePauseResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether acceleration has been paused. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The site\&quot;s acceleration is paused.</description></item>
        /// <item><description>false: The site is accelerating normally.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
