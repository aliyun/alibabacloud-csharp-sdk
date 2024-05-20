// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionBatchSyncResponseBody : TeaModel {
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        [NameInMap("FailedList")]
        [Validation(Required=false)]
        public List<CreateAppSessionBatchSyncResponseBodyFailedList> FailedList { get; set; }
        public class CreateAppSessionBatchSyncResponseBodyFailedList : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CustomSessionId")]
            [Validation(Required=false)]
            public string CustomSessionId { get; set; }

            [NameInMap("FailedInfo")]
            [Validation(Required=false)]
            public CreateAppSessionBatchSyncResponseBodyFailedListFailedInfo FailedInfo { get; set; }
            public class CreateAppSessionBatchSyncResponseBodyFailedListFailedInfo : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<CreateAppSessionBatchSyncResponseBodyResultList> ResultList { get; set; }
        public class CreateAppSessionBatchSyncResponseBodyResultList : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("BizInfo")]
            [Validation(Required=false)]
            public CreateAppSessionBatchSyncResponseBodyResultListBizInfo BizInfo { get; set; }
            public class CreateAppSessionBatchSyncResponseBodyResultListBizInfo : TeaModel {
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public Dictionary<string, object> Biz { get; set; }

                [NameInMap("Endpoints")]
                [Validation(Required=false)]
                public List<CreateAppSessionBatchSyncResponseBodyResultListBizInfoEndpoints> Endpoints { get; set; }
                public class CreateAppSessionBatchSyncResponseBodyResultListBizInfoEndpoints : TeaModel {
                    [NameInMap("AccessHost")]
                    [Validation(Required=false)]
                    public string AccessHost { get; set; }

                    [NameInMap("AccessPort")]
                    [Validation(Required=false)]
                    public string AccessPort { get; set; }

                    [NameInMap("DistrictId")]
                    [Validation(Required=false)]
                    public string DistrictId { get; set; }

                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public string Isp { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("CustomSessionId")]
            [Validation(Required=false)]
            public string CustomSessionId { get; set; }

            [NameInMap("PlatformSessionId")]
            [Validation(Required=false)]
            public string PlatformSessionId { get; set; }

        }

    }

}
