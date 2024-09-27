// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddCustomLineResponseBody : TeaModel {
        /// <summary>
        /// <para>The code of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0yc-597</para>
        /// </summary>
        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

        /// <summary>
        /// <para>The unique ID of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>597</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public long? LineId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
