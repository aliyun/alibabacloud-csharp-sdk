// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class HttpDeliveryHeaderParamValue : TeaModel {
        /// <summary>
        /// <para>The value of the custom HTTP delivery request header.</para>
        /// <remarks>
        /// <para>Key-map. The value can be a static value, a dynamic function, or a dynamic value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>x-auth: sk-***</para>
        /// </summary>
        [NameInMap("StaticValue")]
        [Validation(Required=false)]
        public string StaticValue { get; set; }

    }

}
