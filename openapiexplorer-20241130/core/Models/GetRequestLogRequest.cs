// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetRequestLogRequest : TeaModel {
        /// <summary>
        /// <para>The request ID returned by the API for which you want to query the log. The value is the universally unique identifiers (UUID) of the API request and must be uppercase.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123E4567-E89B-12D3-A456-426614174000</para>
        /// </summary>
        [NameInMap("logRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

    }

}
