// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DeleteModelOperatorApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the API key for which the deletion is accepted. The return of this field does not indicate that the underlying cleanup is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApiKeyId")]
        [Validation(Required=false)]
        public int? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
