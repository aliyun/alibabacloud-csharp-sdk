// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class GenerateUserSessionTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34C2713A-2270-5EEC-825E-115F9AD3BAC9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>960f499au184m7****</para>
        /// </summary>
        [NameInMap("UserSessionToken")]
        [Validation(Required=false)]
        public string UserSessionToken { get; set; }

    }

}
