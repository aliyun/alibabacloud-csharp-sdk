// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class CreateApiRequest : TeaModel {
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public string ErrorCodeSamples { get; set; }

        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public string OpenIdConnectConfig { get; set; }

        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public string RequestConfig { get; set; }

        [NameInMap("RequestParamters")]
        [Validation(Required=false)]
        public string RequestParamters { get; set; }

        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public string ResultDescriptions { get; set; }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public string ServiceParametersMap { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
