// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class QueryGenerateDevicesRecordResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGenerateDevicesRecordResponseBodyData Data { get; set; }
        public class QueryGenerateDevicesRecordResponseBodyData : TeaModel {
            [NameInMap("ListData")]
            [Validation(Required=false)]
            public List<QueryGenerateDevicesRecordResponseBodyDataListData> ListData { get; set; }
            public class QueryGenerateDevicesRecordResponseBodyDataListData : TeaModel {
                [NameInMap("ApplyDeviceCount")]
                [Validation(Required=false)]
                public long? ApplyDeviceCount { get; set; }

                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public string BatchId { get; set; }

                [NameInMap("BatchStatus")]
                [Validation(Required=false)]
                public string BatchStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("OperateUid")]
                [Validation(Required=false)]
                public long? OperateUid { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("SpecCode")]
                [Validation(Required=false)]
                public string SpecCode { get; set; }

                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
