// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class QuerySDKInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySDKInstancesResponseBodyData Data { get; set; }
        public class QuerySDKInstancesResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<QuerySDKInstancesResponseBodyDataContent> Content { get; set; }
            public class QuerySDKInstancesResponseBodyDataContent : TeaModel {
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LatestBuild")]
                [Validation(Required=false)]
                public string LatestBuild { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("Recipe")]
                [Validation(Required=false)]
                public string Recipe { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("ValidFromDate")]
                [Validation(Required=false)]
                public string ValidFromDate { get; set; }

                [NameInMap("ValidToDate")]
                [Validation(Required=false)]
                public string ValidToDate { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Ok")]
        [Validation(Required=false)]
        public bool? Ok { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
