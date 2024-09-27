// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class SetFingerPrintTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0711abb9-4cf8-41b2-9d0e-b51209468631;da4VFPNxwY3CZegFjOrCNw==;iHp2l9/qGcfD4tWx7jZIZQ==</para>
        /// </summary>
        [NameInMap("EncryptedPassword")]
        [Validation(Required=false)]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CDE666EA-4FCD-5024-895C-8698E3D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
