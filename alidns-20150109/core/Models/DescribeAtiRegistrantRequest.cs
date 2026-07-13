// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeAtiRegistrantRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the real-name verified registrant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2072277378616354816</para>
        /// </summary>
        [NameInMap("RegistrantId")]
        [Validation(Required=false)]
        public string RegistrantId { get; set; }

    }

}
