// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayErrorAccessLogsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9BF49BD-3037-5006-B379-656ECBA6F56C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
