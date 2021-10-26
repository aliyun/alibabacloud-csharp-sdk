// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAccordanceApisResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("AccordanceApis")]
        [Validation(Required=false)]
        public DescribeAccordanceApisResponseBodyAccordanceApis AccordanceApis { get; set; }
        public class DescribeAccordanceApisResponseBodyAccordanceApis : TeaModel {
            [NameInMap("AccordanceApi")]
            [Validation(Required=false)]
            public List<DescribeAccordanceApisResponseBodyAccordanceApisAccordanceApi> AccordanceApi { get; set; }
            public class DescribeAccordanceApisResponseBodyAccordanceApisAccordanceApi : TeaModel {
                public DescribeAccordanceApisResponseBodyAccordanceApisAccordanceApiSource Source { get; set; }
                public class DescribeAccordanceApisResponseBodyAccordanceApisAccordanceApiSource : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("StageName")]
                    [Validation(Required=false)]
                    public string StageName { get; set; }

                    [NameInMap("ApiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }
                public DescribeAccordanceApisResponseBodyAccordanceApisAccordanceApiTarget Target { get; set; }
                public class DescribeAccordanceApisResponseBodyAccordanceApisAccordanceApiTarget : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("ApiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }
            }
        };

    }

}
