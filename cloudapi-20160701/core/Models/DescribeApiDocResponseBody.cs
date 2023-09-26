// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class DescribeApiDocResponseBody : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("BodyFormat")]
        [Validation(Required=false)]
        public string BodyFormat { get; set; }

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
        public DescribeApiDocResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiDocResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiDocResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
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

        [NameInMap("HttpMethod")]
        [Validation(Required=false)]
        public string HttpMethod { get; set; }

        [NameInMap("HttpProtocol")]
        [Validation(Required=false)]
        public string HttpProtocol { get; set; }

        [NameInMap("Mock")]
        [Validation(Required=false)]
        public string Mock { get; set; }

        [NameInMap("MockResult")]
        [Validation(Required=false)]
        public string MockResult { get; set; }

        [NameInMap("OriginResultDescription")]
        [Validation(Required=false)]
        public string OriginResultDescription { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("PathParameters")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyPathParameters PathParameters { get; set; }
        public class DescribeApiDocResponseBodyPathParameters : TeaModel {
            [NameInMap("PathParameter")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyPathParametersPathParameter> PathParameter { get; set; }
            public class DescribeApiDocResponseBodyPathParametersPathParameter : TeaModel {
                [NameInMap("ApiParameterName")]
                [Validation(Required=false)]
                public string ApiParameterName { get; set; }

                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

        }

        [NameInMap("PostBodyDescription")]
        [Validation(Required=false)]
        public string PostBodyDescription { get; set; }

        [NameInMap("PostBodyType")]
        [Validation(Required=false)]
        public string PostBodyType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestBody")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestBody RequestBody { get; set; }
        public class DescribeApiDocResponseBodyRequestBody : TeaModel {
            [NameInMap("RequestParam")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyRequestBodyRequestParam> RequestParam { get; set; }
            public class DescribeApiDocResponseBodyRequestBodyRequestParam : TeaModel {
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

                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

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

        [NameInMap("RequestHeaders")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestHeaders RequestHeaders { get; set; }
        public class DescribeApiDocResponseBodyRequestHeaders : TeaModel {
            [NameInMap("RequestParam")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyRequestHeadersRequestParam> RequestParam { get; set; }
            public class DescribeApiDocResponseBodyRequestHeadersRequestParam : TeaModel {
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

                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestMode")]
        [Validation(Required=false)]
        public string RequestMode { get; set; }

        [NameInMap("RequestQueries")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestQueries RequestQueries { get; set; }
        public class DescribeApiDocResponseBodyRequestQueries : TeaModel {
            [NameInMap("RequestParam")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyRequestQueriesRequestParam> RequestParam { get; set; }
            public class DescribeApiDocResponseBodyRequestQueriesRequestParam : TeaModel {
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

                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

                [NameInMap("JsonScheme")]
                [Validation(Required=false)]
                public string JsonScheme { get; set; }

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

        [NameInMap("ServiceTimeout")]
        [Validation(Required=false)]
        public int? ServiceTimeout { get; set; }

        [NameInMap("ServiceVpcEnable")]
        [Validation(Required=false)]
        public string ServiceVpcEnable { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

    }

}
