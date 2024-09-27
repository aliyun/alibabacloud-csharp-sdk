// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class RefreshLoginTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>v1c27bab6c205b2fdfac916434306375722776d6aa89e30b7836d18c95ade9137f0f5ac4325260782184e96ee2b3f0****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
