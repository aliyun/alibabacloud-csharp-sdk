// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class DeleteSceneResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>95E6F720-6786-53BD-9982-C9A636CEA627</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:\&quot;200\&quot;,\&quot;RequestId\&quot;:\&quot;B946877A-8BDC-55AD-BE7E-85B75B2527E5\&quot;,\&quot;data\&quot;:true}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

    }

}
