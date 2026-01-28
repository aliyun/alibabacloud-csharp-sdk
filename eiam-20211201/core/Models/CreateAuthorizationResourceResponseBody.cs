// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateAuthorizationResourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>arres_01kgh3jvt7pk093rv6giu0c0qxxxx</para>
        /// </summary>
        [NameInMap("AuthorizationResourceId")]
        [Validation(Required=false)]
        public string AuthorizationResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
