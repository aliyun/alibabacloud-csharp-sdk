// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>auth-14e80de4866bf7171264a9b40661</para>
        /// </summary>
        [NameInMap("authorizationId")]
        [Validation(Required=false)]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5FE84246-BB17-54BF-9F7A-F496270AC6DA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
