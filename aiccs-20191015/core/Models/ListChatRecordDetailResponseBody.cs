// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListChatRecordDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public ListChatRecordDetailResponseBodyResultData ResultData { get; set; }
        public class ListChatRecordDetailResponseBodyResultData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListChatRecordDetailResponseBodyResultDataData> Data { get; set; }
            public class ListChatRecordDetailResponseBodyResultDataData : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("MessageList")]
                [Validation(Required=false)]
                public List<ListChatRecordDetailResponseBodyResultDataDataMessageList> MessageList { get; set; }
                public class ListChatRecordDetailResponseBodyResultDataDataMessageList : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("MsgType")]
                    [Validation(Required=false)]
                    public string MsgType { get; set; }

                    [NameInMap("SenderName")]
                    [Validation(Required=false)]
                    public string SenderName { get; set; }

                    [NameInMap("SenderType")]
                    [Validation(Required=false)]
                    public long? SenderType { get; set; }

                }

                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public long? OnePageSize { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public long? TotalResults { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
