// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateTrustedOriginResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-example</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trusted origin ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>to_example</para>
        /// </summary>
        [NameInMap("TrustedOriginId")]
        [Validation(Required=false)]
        public string TrustedOriginId { get; set; }

    }

}
