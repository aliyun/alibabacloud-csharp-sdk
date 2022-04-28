// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiConfigurationRequest : TeaModel {
        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("AppCodeAuthType")]
        [Validation(Required=false)]
        public string AppCodeAuthType { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        [NameInMap("BodyFormat")]
        [Validation(Required=false)]
        public string BodyFormat { get; set; }

        [NameInMap("BodyModel")]
        [Validation(Required=false)]
        public string BodyModel { get; set; }

        [NameInMap("ContentTypeCategory")]
        [Validation(Required=false)]
        public string ContentTypeCategory { get; set; }

        [NameInMap("ContentTypeValue")]
        [Validation(Required=false)]
        public string ContentTypeValue { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public string ErrorCodeSamples { get; set; }

        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        [NameInMap("FunctionComputeConfig")]
        [Validation(Required=false)]
        public string FunctionComputeConfig { get; set; }

        [NameInMap("HttpConfig")]
        [Validation(Required=false)]
        public string HttpConfig { get; set; }

        [NameInMap("MockConfig")]
        [Validation(Required=false)]
        public string MockConfig { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("OssConfig")]
        [Validation(Required=false)]
        public string OssConfig { get; set; }

        [NameInMap("PostBodyDescription")]
        [Validation(Required=false)]
        public string PostBodyDescription { get; set; }

        [NameInMap("RequestHttpMethod")]
        [Validation(Required=false)]
        public string RequestHttpMethod { get; set; }

        [NameInMap("RequestMode")]
        [Validation(Required=false)]
        public string RequestMode { get; set; }

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public string RequestParameters { get; set; }

        [NameInMap("RequestPath")]
        [Validation(Required=false)]
        public string RequestPath { get; set; }

        [NameInMap("RequestProtocol")]
        [Validation(Required=false)]
        public string RequestProtocol { get; set; }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public string ServiceParametersMap { get; set; }

        [NameInMap("ServiceProtocol")]
        [Validation(Required=false)]
        public string ServiceProtocol { get; set; }

        [NameInMap("ServiceTimeout")]
        [Validation(Required=false)]
        public int? ServiceTimeout { get; set; }

        [NameInMap("UseBackendService")]
        [Validation(Required=false)]
        public bool? UseBackendService { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("VpcConfig")]
        [Validation(Required=false)]
        public string VpcConfig { get; set; }

    }

}
