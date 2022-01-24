// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiResponseBody : TeaModel {
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

        [NameInMap("BackendConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyBackendConfig BackendConfig { get; set; }
        public class DescribeApiResponseBodyBackendConfig : TeaModel {
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }
        };

        [NameInMap("BackendEnable")]
        [Validation(Required=false)]
        public bool? BackendEnable { get; set; }

        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyConstantParameters ConstantParameters { get; set; }
        public class DescribeApiResponseBodyConstantParameters : TeaModel {
            [NameInMap("ConstantParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyConstantParametersConstantParameter> ConstantParameter { get; set; }
            public class DescribeApiResponseBodyConstantParametersConstantParameter : TeaModel {
                public string ConstantValue { get; set; }
                public string Description { get; set; }
                public string Location { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("CustomSystemParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyCustomSystemParameters CustomSystemParameters { get; set; }
        public class DescribeApiResponseBodyCustomSystemParameters : TeaModel {
            [NameInMap("CustomSystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyCustomSystemParametersCustomSystemParameter> CustomSystemParameter { get; set; }
            public class DescribeApiResponseBodyCustomSystemParametersCustomSystemParameter : TeaModel {
                public string DemoValue { get; set; }
                public string Description { get; set; }
                public string Location { get; set; }
                public string ParameterName { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("DeployedInfos")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyDeployedInfos DeployedInfos { get; set; }
        public class DescribeApiResponseBodyDeployedInfos : TeaModel {
            [NameInMap("DeployedInfo")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyDeployedInfosDeployedInfo> DeployedInfo { get; set; }
            public class DescribeApiResponseBodyDeployedInfosDeployedInfo : TeaModel {
                public string DeployedStatus { get; set; }
                public string EffectiveVersion { get; set; }
                public string StageName { get; set; }
            }
        };

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                public string Code { get; set; }
                public string Description { get; set; }
                public string Message { get; set; }
                public string Model { get; set; }
            }
        };

        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        [NameInMap("ForceNonceCheck")]
        [Validation(Required=false)]
        public bool? ForceNonceCheck { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Mock")]
        [Validation(Required=false)]
        public string Mock { get; set; }

        [NameInMap("MockResult")]
        [Validation(Required=false)]
        public string MockResult { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeApiResponseBodyOpenIdConnectConfig : TeaModel {
            [NameInMap("IdTokenParamName")]
            [Validation(Required=false)]
            public string IdTokenParamName { get; set; }
            [NameInMap("OpenIdApiType")]
            [Validation(Required=false)]
            public string OpenIdApiType { get; set; }
            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }
            [NameInMap("PublicKeyId")]
            [Validation(Required=false)]
            public string PublicKeyId { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiResponseBodyRequestConfig : TeaModel {
            [NameInMap("BodyFormat")]
            [Validation(Required=false)]
            public string BodyFormat { get; set; }
            [NameInMap("BodyModel")]
            [Validation(Required=false)]
            public string BodyModel { get; set; }
            [NameInMap("PostBodyDescription")]
            [Validation(Required=false)]
            public string PostBodyDescription { get; set; }
            [NameInMap("RequestHttpMethod")]
            [Validation(Required=false)]
            public string RequestHttpMethod { get; set; }
            [NameInMap("RequestMode")]
            [Validation(Required=false)]
            public string RequestMode { get; set; }
            [NameInMap("RequestPath")]
            [Validation(Required=false)]
            public string RequestPath { get; set; }
            [NameInMap("RequestProtocol")]
            [Validation(Required=false)]
            public string RequestProtocol { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeApiResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeApiResponseBodyRequestParametersRequestParameter : TeaModel {
                public string ApiParameterName { get; set; }
                public string ArrayItemsType { get; set; }
                public string DefaultValue { get; set; }
                public string DemoValue { get; set; }
                public string Description { get; set; }
                public int? DocOrder { get; set; }
                public string DocShow { get; set; }
                public string EnumValue { get; set; }
                public string JsonScheme { get; set; }
                public string Location { get; set; }
                public long? MaxLength { get; set; }
                public long? MaxValue { get; set; }
                public long? MinLength { get; set; }
                public long? MinValue { get; set; }
                public string ParameterType { get; set; }
                public string RegularExpression { get; set; }
                public string Required { get; set; }
            }
        };

        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyResultDescriptions ResultDescriptions { get; set; }
        public class DescribeApiResponseBodyResultDescriptions : TeaModel {
            [NameInMap("ResultDescription")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyResultDescriptionsResultDescription> ResultDescription { get; set; }
            public class DescribeApiResponseBodyResultDescriptionsResultDescription : TeaModel {
                public string Description { get; set; }
                public bool? HasChild { get; set; }
                public string Id { get; set; }
                public string Key { get; set; }
                public bool? Mandatory { get; set; }
                public string Name { get; set; }
                public string Pid { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeApiResponseBodyServiceConfig : TeaModel {
            [NameInMap("AoneAppName")]
            [Validation(Required=false)]
            public string AoneAppName { get; set; }
            [NameInMap("ContentTypeCatagory")]
            [Validation(Required=false)]
            public string ContentTypeCatagory { get; set; }
            [NameInMap("ContentTypeValue")]
            [Validation(Required=false)]
            public string ContentTypeValue { get; set; }
            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
                [NameInMap("ContentTypeCatagory")]
                [Validation(Required=false)]
                public string ContentTypeCatagory { get; set; }

                [NameInMap("ContentTypeValue")]
                [Validation(Required=false)]
                public string ContentTypeValue { get; set; }

                [NameInMap("FcBaseUrl")]
                [Validation(Required=false)]
                public string FcBaseUrl { get; set; }

                [NameInMap("FcType")]
                [Validation(Required=false)]
                public string FcType { get; set; }

                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("OnlyBusinessPath")]
                [Validation(Required=false)]
                public bool? OnlyBusinessPath { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }
            [NameInMap("Mock")]
            [Validation(Required=false)]
            public string Mock { get; set; }
            [NameInMap("MockHeaders")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigMockHeaders MockHeaders { get; set; }
            public class DescribeApiResponseBodyServiceConfigMockHeaders : TeaModel {
                [NameInMap("MockHeader")]
                [Validation(Required=false)]
                public List<DescribeApiResponseBodyServiceConfigMockHeadersMockHeader> MockHeader { get; set; }
                public class DescribeApiResponseBodyServiceConfigMockHeadersMockHeader : TeaModel {
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    [NameInMap("HeaderValue")]
                    [Validation(Required=false)]
                    public string HeaderValue { get; set; }

                }

            }
            [NameInMap("MockResult")]
            [Validation(Required=false)]
            public string MockResult { get; set; }
            [NameInMap("MockStatusCode")]
            [Validation(Required=false)]
            public int? MockStatusCode { get; set; }
            [NameInMap("OssConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigOssConfig OssConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigOssConfig : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("OssRegionId")]
                [Validation(Required=false)]
                public string OssRegionId { get; set; }

            }
            [NameInMap("ServiceAddress")]
            [Validation(Required=false)]
            public string ServiceAddress { get; set; }
            [NameInMap("ServiceHttpMethod")]
            [Validation(Required=false)]
            public string ServiceHttpMethod { get; set; }
            [NameInMap("ServicePath")]
            [Validation(Required=false)]
            public string ServicePath { get; set; }
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }
            [NameInMap("ServiceTimeout")]
            [Validation(Required=false)]
            public int? ServiceTimeout { get; set; }
            [NameInMap("ServiceVpcEnable")]
            [Validation(Required=false)]
            public string ServiceVpcEnable { get; set; }
            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigVpcConfig : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcScheme")]
                [Validation(Required=false)]
                public string VpcScheme { get; set; }

            }
        };

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceParameters ServiceParameters { get; set; }
        public class DescribeApiResponseBodyServiceParameters : TeaModel {
            [NameInMap("ServiceParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyServiceParametersServiceParameter> ServiceParameter { get; set; }
            public class DescribeApiResponseBodyServiceParametersServiceParameter : TeaModel {
                public string Location { get; set; }
                public string ParameterType { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceParametersMap ServiceParametersMap { get; set; }
        public class DescribeApiResponseBodyServiceParametersMap : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyServiceParametersMapServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeApiResponseBodyServiceParametersMapServiceParameterMap : TeaModel {
                public string RequestParameterName { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeApiResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeApiResponseBodySystemParametersSystemParameter : TeaModel {
                public string DemoValue { get; set; }
                public string Description { get; set; }
                public string Location { get; set; }
                public string ParameterName { get; set; }
                public string ServiceParameterName { get; set; }
            }
        };

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
