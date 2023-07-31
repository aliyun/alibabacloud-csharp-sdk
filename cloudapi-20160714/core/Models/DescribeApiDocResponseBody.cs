// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiDocResponseBody : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestConfig")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiDocResponseBodyRequestConfig : TeaModel {
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

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeApiDocResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeApiDocResponseBodyRequestParametersRequestParameter : TeaModel {
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

                /// <summary>
                /// JSON scheme
                /// </summary>
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

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
