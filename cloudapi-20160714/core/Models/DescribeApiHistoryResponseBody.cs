// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiHistoryResponseBody : TeaModel {
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
        public DescribeApiHistoryResponseBodyBackendConfig BackendConfig { get; set; }
        public class DescribeApiHistoryResponseBodyBackendConfig : TeaModel {
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }

            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

        }

        [NameInMap("BackendEnable")]
        [Validation(Required=false)]
        public bool? BackendEnable { get; set; }

        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyConstantParameters ConstantParameters { get; set; }
        public class DescribeApiHistoryResponseBodyConstantParameters : TeaModel {
            [NameInMap("ConstantParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyConstantParametersConstantParameter> ConstantParameter { get; set; }
            public class DescribeApiHistoryResponseBodyConstantParametersConstantParameter : TeaModel {
                [NameInMap("ConstantValue")]
                [Validation(Required=false)]
                public string ConstantValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        [NameInMap("CustomSystemParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyCustomSystemParameters CustomSystemParameters { get; set; }
        public class DescribeApiHistoryResponseBodyCustomSystemParameters : TeaModel {
            [NameInMap("CustomSystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyCustomSystemParametersCustomSystemParameter> CustomSystemParameter { get; set; }
            public class DescribeApiHistoryResponseBodyCustomSystemParametersCustomSystemParameter : TeaModel {
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        [NameInMap("DeployedTime")]
        [Validation(Required=false)]
        public string DeployedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiHistoryResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiHistoryResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

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

        [NameInMap("HistoryVersion")]
        [Validation(Required=false)]
        public string HistoryVersion { get; set; }

        [NameInMap("OpenIdConnectConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyOpenIdConnectConfig OpenIdConnectConfig { get; set; }
        public class DescribeApiHistoryResponseBodyOpenIdConnectConfig : TeaModel {
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

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiHistoryResponseBodyRequestConfig : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeApiHistoryResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeApiHistoryResponseBodyRequestParametersRequestParameter : TeaModel {
                [NameInMap("ApiParameterName")]
                [Validation(Required=false)]
                public string ApiParameterName { get; set; }

                [NameInMap("ArrayItemsType")]
                [Validation(Required=false)]
                public string ArrayItemsType { get; set; }

                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DocOrder")]
                [Validation(Required=false)]
                public int? DocOrder { get; set; }

                [NameInMap("DocShow")]
                [Validation(Required=false)]
                public string DocShow { get; set; }

                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public long? MaxValue { get; set; }

                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public long? MinValue { get; set; }

                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                [NameInMap("RegularExpression")]
                [Validation(Required=false)]
                public string RegularExpression { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public string Required { get; set; }

            }

        }

        [NameInMap("ResultBodyModel")]
        [Validation(Required=false)]
        public string ResultBodyModel { get; set; }

        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyResultDescriptions ResultDescriptions { get; set; }
        public class DescribeApiHistoryResponseBodyResultDescriptions : TeaModel {
            [NameInMap("ResultDescription")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyResultDescriptionsResultDescription> ResultDescription { get; set; }
            public class DescribeApiHistoryResponseBodyResultDescriptionsResultDescription : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HasChild")]
                [Validation(Required=false)]
                public bool? HasChild { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Mandatory")]
                [Validation(Required=false)]
                public bool? Mandatory { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyServiceConfig ServiceConfig { get; set; }
        public class DescribeApiHistoryResponseBodyServiceConfig : TeaModel {
            [NameInMap("ContentTypeCatagory")]
            [Validation(Required=false)]
            public string ContentTypeCatagory { get; set; }

            [NameInMap("ContentTypeValue")]
            [Validation(Required=false)]
            public string ContentTypeValue { get; set; }

            [NameInMap("EventBridgeConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigEventBridgeConfig EventBridgeConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigEventBridgeConfig : TeaModel {
                [NameInMap("EventBridgeRegionId")]
                [Validation(Required=false)]
                public string EventBridgeRegionId { get; set; }

                [NameInMap("EventBus")]
                [Validation(Required=false)]
                public string EventBus { get; set; }

                [NameInMap("EventSource")]
                [Validation(Required=false)]
                public string EventSource { get; set; }

                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

            }

            [NameInMap("FunctionComputeConfig")]
            [Validation(Required=false)]
            public DescribeApiHistoryResponseBodyServiceConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigFunctionComputeConfig : TeaModel {
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
            public DescribeApiHistoryResponseBodyServiceConfigMockHeaders MockHeaders { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigMockHeaders : TeaModel {
                [NameInMap("MockHeader")]
                [Validation(Required=false)]
                public List<DescribeApiHistoryResponseBodyServiceConfigMockHeadersMockHeader> MockHeader { get; set; }
                public class DescribeApiHistoryResponseBodyServiceConfigMockHeadersMockHeader : TeaModel {
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
            public DescribeApiHistoryResponseBodyServiceConfigOssConfig OssConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigOssConfig : TeaModel {
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
            public DescribeApiHistoryResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeApiHistoryResponseBodyServiceConfigVpcConfig : TeaModel {
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

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyServiceParameters ServiceParameters { get; set; }
        public class DescribeApiHistoryResponseBodyServiceParameters : TeaModel {
            [NameInMap("ServiceParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyServiceParametersServiceParameter> ServiceParameter { get; set; }
            public class DescribeApiHistoryResponseBodyServiceParametersServiceParameter : TeaModel {
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("ParameterType")]
                [Validation(Required=false)]
                public string ParameterType { get; set; }

                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        [NameInMap("ServiceParametersMap")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodyServiceParametersMap ServiceParametersMap { get; set; }
        public class DescribeApiHistoryResponseBodyServiceParametersMap : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodyServiceParametersMapServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeApiHistoryResponseBodyServiceParametersMapServiceParameterMap : TeaModel {
                [NameInMap("RequestParameterName")]
                [Validation(Required=false)]
                public string RequestParameterName { get; set; }

                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeApiHistoryResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeApiHistoryResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiHistoryResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeApiHistoryResponseBodySystemParametersSystemParameter : TeaModel {
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("WebSocketApiType")]
        [Validation(Required=false)]
        public string WebSocketApiType { get; set; }

    }

}
