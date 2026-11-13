// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateModelOperatorApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApiKeyId")]
        [Validation(Required=false)]
        public int? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The acceptance status of the creation request. If the request is successfully accepted, the value is always Creating, which does not indicate that the API key is available. Call DescribeModelOperatorApiKey or ListModelOperatorApiKeys to query the subsequent status. You can obtain the endpoint only when the status is Running, and obtain the plaintext key by calling DescribeModelOperatorApiKey. Each call to this operation creates a new API key. Do not repeatedly call this operation to check the progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
