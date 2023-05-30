// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class DeleteFunctionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// $.parameters[8].schema.description
        /// </summary>
        [NameInMap("If-Match")]
        [Validation(Required=false)]
        public string IfMatch { get; set; }

        /// <summary>
        /// {"name":"DeleteFunction","product":"FC-Open","version":"2021-04-06","path":"/2021-04-06/services/{serviceName}/functions/{functionName}","deprecated":0,"method":"DELETE","protocol":"HTTP|HTTPS","hidden":0,"timeout":10000,"parameter_type":"Single","params":"[{\"name\":\"If-Match\",\"position\":\"Header\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The ETag value of the resource. This value is used to ensure that the modified resource is consistent with the resource to be modified. The ETag value is returned in the responses of the CREATE, GET, and UPDATE operations.\",\"description\":\"The ETag value of the resource. This value is used to ensure that the modified resource is consistent with the resource to be modified. The ETag value is returned in the responses of the CREATE, GET, and UPDATE operations. \",\"example\":\"e19d5cd5af0378da05f63f891c7467af\"},{\"name\":\"serviceName\",\"position\":\"Path\",\"required\":true,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The name of the service.\",\"description\":\"The name of the service. \",\"example\":\"demoService\"},{\"name\":\"functionName\",\"position\":\"Path\",\"required\":true,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The name of the function.\",\"description\":\"The name of the function. \",\"example\":\"demoFunction\"},{\"name\":\"X-Fc-Account-Id\",\"position\":\"Header\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"description\":\"The ID of your Alibaba Cloud account. \",\"example\":\"188077086902****\"},{\"name\":\"X-Fc-Date\",\"position\":\"Header\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"description\":\"The start time when the function is invoked. Specify the time in the yyyy-mm-ddhh:mm:ss format. \",\"example\":\"2022-01-01 12:00:00\"},{\"name\":\"X-Fc-Trace-Id\",\"position\":\"Header\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"description\":\"The trace ID of the request for Function Compute API. The value is the same as that of the requestId parameter in the response. \",\"example\":\"test-trace-id\"}]","response_headers":"[]","response":"{}","errors":"{}"}
        /// </summary>
        [NameInMap("X-Fc-Account-Id")]
        [Validation(Required=false)]
        public string XFcAccountId { get; set; }

        [NameInMap("X-Fc-Date")]
        [Validation(Required=false)]
        public string XFcDate { get; set; }

        [NameInMap("X-Fc-Trace-Id")]
        [Validation(Required=false)]
        public string XFcTraceId { get; set; }

    }

}
