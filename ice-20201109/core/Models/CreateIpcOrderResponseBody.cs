// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateIpcOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("PurchaseStatus")]
        [Validation(Required=false)]
        public string PurchaseStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>36-3C1E-4417-BDB2-1E034F</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
