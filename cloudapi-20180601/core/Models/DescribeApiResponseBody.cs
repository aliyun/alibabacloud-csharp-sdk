// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
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

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyConstantParameters ConstantParameters { get; set; }
        public class DescribeApiResponseBodyConstantParameters : TeaModel {
            [NameInMap("ConstantParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyConstantParametersConstantParameter> ConstantParameter { get; set; }
            public class DescribeApiResponseBodyConstantParametersConstantParameter : TeaModel {
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

        [NameInMap("DeployedInfos")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyDeployedInfos DeployedInfos { get; set; }
        public class DescribeApiResponseBodyDeployedInfos : TeaModel {
            [NameInMap("DeployedInfo")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyDeployedInfosDeployedInfo> DeployedInfo { get; set; }
            public class DescribeApiResponseBodyDeployedInfosDeployedInfo : TeaModel {
                [NameInMap("DeployedStatus")]
                [Validation(Required=false)]
                public string DeployedStatus { get; set; }

                [NameInMap("EffectiveVersion")]
                [Validation(Required=false)]
                public string EffectiveVersion { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
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

        }

        [NameInMap("OriginResultDescription")]
        [Validation(Required=false)]
        public string OriginResultDescription { get; set; }

        [NameInMap("ParametersMapObject")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyParametersMapObject ParametersMapObject { get; set; }
        public class DescribeApiResponseBodyParametersMapObject : TeaModel {
            [NameInMap("ServiceParameterMap")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyParametersMapObjectServiceParameterMap> ServiceParameterMap { get; set; }
            public class DescribeApiResponseBodyParametersMapObjectServiceParameterMap : TeaModel {
                [NameInMap("RequestParameterName")]
                [Validation(Required=false)]
                public string RequestParameterName { get; set; }

                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

            }

        }

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

        [NameInMap("RequestParametersObject")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyRequestParametersObject RequestParametersObject { get; set; }
        public class DescribeApiResponseBodyRequestParametersObject : TeaModel {
            [NameInMap("RequestParam")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyRequestParametersObjectRequestParam> RequestParam { get; set; }
            public class DescribeApiResponseBodyRequestParametersObjectRequestParam : TeaModel {
                [NameInMap("ApiParameterName")]
                [Validation(Required=false)]
                public string ApiParameterName { get; set; }

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
                public string DocOrder { get; set; }

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
                [NameInMap("FcRegionId")]
                [Validation(Required=false)]
                public string FcRegionId { get; set; }

                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

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

            [NameInMap("MockResult")]
            [Validation(Required=false)]
            public string MockResult { get; set; }

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
            public string ServiceTimeout { get; set; }

            [NameInMap("ServiceVpcEnable")]
            [Validation(Required=false)]
            public string ServiceVpcEnable { get; set; }

            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeApiResponseBodyServiceConfigVpcConfig VpcConfig { get; set; }
            public class DescribeApiResponseBodyServiceConfigVpcConfig : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

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

            }

        }

        [NameInMap("ServiceParametersObject")]
        [Validation(Required=false)]
        public DescribeApiResponseBodyServiceParametersObject ServiceParametersObject { get; set; }
        public class DescribeApiResponseBodyServiceParametersObject : TeaModel {
            [NameInMap("ServiceParam")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodyServiceParametersObjectServiceParam> ServiceParam { get; set; }
            public class DescribeApiResponseBodyServiceParametersObjectServiceParam : TeaModel {
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("ServiceParameterName")]
                [Validation(Required=false)]
                public string ServiceParameterName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeApiResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeApiResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeApiResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeApiResponseBodySystemParametersSystemParameter : TeaModel {
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
