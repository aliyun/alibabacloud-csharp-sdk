// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployedApiResponseBody : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        [NameInMap("AllowSignatureMethod")]
        [Validation(Required=false)]
        public string AllowSignatureMethod { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("DeployedTime")]
        [Validation(Required=false)]
        public string DeployedTime { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeDeployedApiResponseBodyRequestConfig : TeaModel {
            [NameInMap("BodyModel")]
            [Validation(Required=false)]
            public string BodyModel { get; set; }
            [NameInMap("RequestPath")]
            [Validation(Required=false)]
            public string RequestPath { get; set; }
            [NameInMap("RequestHttpMethod")]
            [Validation(Required=false)]
            public string RequestHttpMethod { get; set; }
            [NameInMap("BodyFormat")]
            [Validation(Required=false)]
            public string BodyFormat { get; set; }
            [NameInMap("RequestMode")]
            [Validation(Required=false)]
            public string RequestMode { get; set; }
            [NameInMap("PostBodyDescription")]
            [Validation(Required=false)]
            public string PostBodyDescription { get; set; }
            [NameInMap("RequestProtocol")]
            [Validation(Required=false)]
            public string RequestProtocol { get; set; }
        };

        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeDeployedApiResponseBodyServiceConfig : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("MockStatusCode")]
            [Validation(Required=false)]
            public int? MockStatusCode { get; set; }
            [NameInMap("ServicePath")]
            [Validation(Required=false)]
            public string ServicePath { get; set; }
            [NameInMap("Mock")]
            [Validation(Required=false)]
            public string Mock { get; set; }
            [NameInMap("ServiceAddress")]
            [Validation(Required=false)]
            public string ServiceAddress { get; set; }
            [NameInMap("ServiceVpcEnable")]
            [Validation(Required=false)]
            public string ServiceVpcEnable { get; set; }
            [NameInMap("MockResult")]
            [Validation(Required=false)]
            public string MockResult { get; set; }
            [NameInMap("ServiceHttpMethod")]
            [Validation(Required=false)]
            public string ServiceHttpMethod { get; set; }
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }
            [NameInMap("ServiceTimeout")]
            [Validation(Required=false)]
            public int? ServiceTimeout { get; set; }
            [NameInMap("MockHeaders")]
            [Validation(Required=false)]
            public DescribeDeployedApiResponseBodyServiceConfigMockHeaders MockHeaders { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigMockHeaders : TeaModel {
                [NameInMap("MockHeader")]
                [Validation(Required=false)]
                public List<DescribeDeployedApiResponseBodyServiceConfigMockHeadersMockHeader> MockHeader { get; set; }
                public class DescribeDeployedApiResponseBodyServiceConfigMockHeadersMockHeader : TeaModel {
                    [NameInMap("HeaderValue")]
                    [Validation(Required=false)]
                    public string HeaderValue { get; set; }

                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                }

            }
            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeDeployedApiResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigVpcConfig : TeaModel {
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }
            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeDeployedApiResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeDeployedApiResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
                [NameInMap("FcType")]
                [Validation(Required=false)]
                public string FcType { get; set; }

                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("FcBaseUrl")]
                [Validation(Required=false)]
                public string FcBaseUrl { get; set; }

                [NameInMap("ContentTypeValue")]
                [Validation(Required=false)]
                public string ContentTypeValue { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("OnlyBusinessPath")]
                [Validation(Required=false)]
                public bool? OnlyBusinessPath { get; set; }

                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("ContentTypeCatagory")]
                [Validation(Required=false)]
                public string ContentTypeCatagory { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

            }
        };

        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeDeployedApiResponseBodyOpenIdConnectConfig : TeaModel {
            [NameInMap("OpenIdApiType")]
            [Validation(Required=false)]
            public string OpenIdApiType { get; set; }
            [NameInMap("IdTokenParamName")]
            [Validation(Required=false)]
            public string IdTokenParamName { get; set; }
            [NameInMap("PublicKeyId")]
            [Validation(Required=false)]
            public string PublicKeyId { get; set; }
            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }
        };

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeDeployedApiResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeDeployedApiResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
                public string Description { get; set; }
            }
        };

        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyResultDescriptions ResultDescriptions { get; set; }
        public class DescribeDeployedApiResponseBodyResultDescriptions : TeaModel {
            [NameInMap("ResultDescription")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyResultDescriptionsResultDescription> ResultDescription { get; set; }
            public class DescribeDeployedApiResponseBodyResultDescriptionsResultDescription : TeaModel {
                public string Type { get; set; }
                public string Key { get; set; }
                public bool? HasChild { get; set; }
                public string Description { get; set; }
                public string Pid { get; set; }
                public bool? Mandatory { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeDeployedApiResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeDeployedApiResponseBodySystemParametersSystemParameter : TeaModel {
                public string DemoValue { get; set; }
                public string Description { get; set; }
                public string ParameterName { get; set; }
                public string Location { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("CustomSystemParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyCustomSystemParameters CustomSystemParameters { get; set; }
        public class DescribeDeployedApiResponseBodyCustomSystemParameters : TeaModel {
            [NameInMap("CustomSystemParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyCustomSystemParametersCustomSystemParameter> CustomSystemParameter { get; set; }
            public class DescribeDeployedApiResponseBodyCustomSystemParametersCustomSystemParameter : TeaModel {
                public string DemoValue { get; set; }
                public string Description { get; set; }
                public string ParameterName { get; set; }
                public string Location { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyConstantParameters ConstantParameters { get; set; }
        public class DescribeDeployedApiResponseBodyConstantParameters : TeaModel {
            [NameInMap("ConstantParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyConstantParametersConstantParameter> ConstantParameter { get; set; }
            public class DescribeDeployedApiResponseBodyConstantParametersConstantParameter : TeaModel {
                public string Description { get; set; }
                public string Location { get; set; }
                public string ServiceParameterName { get; set; }
                public string ConstantValue { get; set; }
            }
        };

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeDeployedApiResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeDeployedApiResponseBodyRequestParametersRequestParameter : TeaModel {
                public string JsonScheme { get; set; }
                public long? MaxValue { get; set; }
                public string ArrayItemsType { get; set; }
                public long? MinValue { get; set; }
                public string DocShow { get; set; }
                public long? MaxLength { get; set; }
                public string DefaultValue { get; set; }
                public string ApiParameterName { get; set; }
                public string EnumValue { get; set; }
                public string DemoValue { get; set; }
                public string Required { get; set; }
                public string Description { get; set; }
                public string ParameterType { get; set; }
                public string RegularExpression { get; set; }
                public long? MinLength { get; set; }
                public int? DocOrder { get; set; }
                public string Location { get; set; }
            }
        };

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyServiceParameters ServiceParameters { get; set; }
        public class DescribeDeployedApiResponseBodyServiceParameters : TeaModel {
            [NameInMap("ServiceParameter")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyServiceParametersServiceParameter> ServiceParameter { get; set; }
            public class DescribeDeployedApiResponseBodyServiceParametersServiceParameter : TeaModel {
                public string Location { get; set; }
                public string ParameterType { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public DescribeDeployedApiResponseBodyServiceParametersMap ServiceParametersMap { get; set; }
        public class DescribeDeployedApiResponseBodyServiceParametersMap : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeDeployedApiResponseBodyServiceParametersMapServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeDeployedApiResponseBodyServiceParametersMapServiceParameterMap : TeaModel {
                public string RequestParameterName { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

    }

}
