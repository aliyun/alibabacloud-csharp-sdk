// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribePurchasedApiResponseBody : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("BodyFormat")]
        [Validation(Required=false)]
        public string BodyFormat { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("PathParameters")]
        [Validation(Required=false)]
        public DescribePurchasedApiResponseBodyPathParameters PathParameters { get; set; }
        public class DescribePurchasedApiResponseBodyPathParameters : TeaModel {
            [NameInMap("PathParameter")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiResponseBodyPathParametersPathParameter> PathParameter { get; set; }
            public class DescribePurchasedApiResponseBodyPathParametersPathParameter : TeaModel {
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
        public DescribePurchasedApiResponseBodyRequestBody RequestBody { get; set; }
        public class DescribePurchasedApiResponseBodyRequestBody : TeaModel {
            [NameInMap("RequestParam")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiResponseBodyRequestBodyRequestParam> RequestParam { get; set; }
            public class DescribePurchasedApiResponseBodyRequestBodyRequestParam : TeaModel {
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

                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public string MaxValue { get; set; }

                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public string MinValue { get; set; }

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
        public DescribePurchasedApiResponseBodyRequestHeaders RequestHeaders { get; set; }
        public class DescribePurchasedApiResponseBodyRequestHeaders : TeaModel {
            [NameInMap("RequestParam")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiResponseBodyRequestHeadersRequestParam> RequestParam { get; set; }
            public class DescribePurchasedApiResponseBodyRequestHeadersRequestParam : TeaModel {
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

        [NameInMap("RequestQueries")]
        [Validation(Required=false)]
        public DescribePurchasedApiResponseBodyRequestQueries RequestQueries { get; set; }
        public class DescribePurchasedApiResponseBodyRequestQueries : TeaModel {
            [NameInMap("RequestParam")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiResponseBodyRequestQueriesRequestParam> RequestParam { get; set; }
            public class DescribePurchasedApiResponseBodyRequestQueriesRequestParam : TeaModel {
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

                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public string MaxValue { get; set; }

                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public string MinValue { get; set; }

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

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
