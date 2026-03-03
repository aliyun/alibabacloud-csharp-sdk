// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class AuditPbcInvokeReviewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>210548f617721779253531433de6e0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CatalogCommonResult Result { get; set; }

    }

}
