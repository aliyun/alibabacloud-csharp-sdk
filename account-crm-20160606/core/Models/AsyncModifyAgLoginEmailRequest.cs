// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class AsyncModifyAgLoginEmailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mpk")]
        [Validation(Required=false)]
        public string Mpk { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NewLoginEmail")]
        [Validation(Required=false)]
        public string NewLoginEmail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

    }

}
