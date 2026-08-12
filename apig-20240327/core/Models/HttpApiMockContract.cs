// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiMockContract : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the Mock feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("responseCode")]
        [Validation(Required=false)]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// <para>The response content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mock content.</para>
        /// </summary>
        [NameInMap("responseContent")]
        [Validation(Required=false)]
        public string ResponseContent { get; set; }

    }

}
