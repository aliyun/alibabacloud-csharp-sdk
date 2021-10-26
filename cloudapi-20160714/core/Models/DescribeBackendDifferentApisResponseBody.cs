// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeBackendDifferentApisResponseBody : TeaModel {
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

        [NameInMap("ConflictApis")]
        [Validation(Required=false)]
        public DescribeBackendDifferentApisResponseBodyConflictApis ConflictApis { get; set; }
        public class DescribeBackendDifferentApisResponseBodyConflictApis : TeaModel {
            [NameInMap("ConflictApi")]
            [Validation(Required=false)]
            public List<DescribeBackendDifferentApisResponseBodyConflictApisConflictApi> ConflictApi { get; set; }
            public class DescribeBackendDifferentApisResponseBodyConflictApisConflictApi : TeaModel {
                public DescribeBackendDifferentApisResponseBodyConflictApisConflictApiSource Source { get; set; }
                public class DescribeBackendDifferentApisResponseBodyConflictApisConflictApiSource : TeaModel {
                    [NameInMap("ApiVersion")]
                    [Validation(Required=false)]
                    public string ApiVersion { get; set; }

                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("VpcName")]
                    [Validation(Required=false)]
                    public string VpcName { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

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
                public DescribeBackendDifferentApisResponseBodyConflictApisConflictApiTarget Target { get; set; }
                public class DescribeBackendDifferentApisResponseBodyConflictApisConflictApiTarget : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("VpcName")]
                    [Validation(Required=false)]
                    public string VpcName { get; set; }

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
