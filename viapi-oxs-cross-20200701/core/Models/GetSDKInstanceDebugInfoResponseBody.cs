// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class GetSDKInstanceDebugInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSDKInstanceDebugInfoResponseBodyData Data { get; set; }
        public class GetSDKInstanceDebugInfoResponseBodyData : TeaModel {
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<GetSDKInstanceDebugInfoResponseBodyDataEvents> Events { get; set; }
            public class GetSDKInstanceDebugInfoResponseBodyDataEvents : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

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

            [NameInMap("ValidFromDate")]
            [Validation(Required=false)]
            public string ValidFromDate { get; set; }

            [NameInMap("ValidToDate")]
            [Validation(Required=false)]
            public string ValidToDate { get; set; }

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
