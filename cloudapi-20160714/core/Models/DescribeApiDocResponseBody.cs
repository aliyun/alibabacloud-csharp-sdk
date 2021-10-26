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

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("DisableInternet")]
        [Validation(Required=false)]
        public bool? DisableInternet { get; set; }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

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

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        public DescribeApiDocResponseBodyRequestConfig RequestConfig { get; set; }
        public class DescribeApiDocResponseBodyRequestConfig : TeaModel {
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

        [NameInMap("ErrorCodeSamples")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyErrorCodeSamples ErrorCodeSamples { get; set; }
        public class DescribeApiDocResponseBodyErrorCodeSamples : TeaModel {
            [NameInMap("ErrorCodeSample")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyErrorCodeSamplesErrorCodeSample> ErrorCodeSample { get; set; }
            public class DescribeApiDocResponseBodyErrorCodeSamplesErrorCodeSample : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
                public string Description { get; set; }
            }
        };

        [NameInMap("ResultDescriptions")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyResultDescriptions ResultDescriptions { get; set; }
        public class DescribeApiDocResponseBodyResultDescriptions : TeaModel {
            [NameInMap("ResultDescription")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyResultDescriptionsResultDescription> ResultDescription { get; set; }
            public class DescribeApiDocResponseBodyResultDescriptionsResultDescription : TeaModel {
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

        [NameInMap("RequestParameters")]
        [Validation(Required=false)]
        public DescribeApiDocResponseBodyRequestParameters RequestParameters { get; set; }
        public class DescribeApiDocResponseBodyRequestParameters : TeaModel {
            [NameInMap("RequestParameter")]
            [Validation(Required=false)]
            public List<DescribeApiDocResponseBodyRequestParametersRequestParameter> RequestParameter { get; set; }
            public class DescribeApiDocResponseBodyRequestParametersRequestParameter : TeaModel {
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

    }

}
