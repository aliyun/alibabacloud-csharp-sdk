// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListChatRecordDetailResponseBody : TeaModel {
        /// <summary>
        /// message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// httpStatusCode
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public ListChatRecordDetailResponseBodyResultData ResultData { get; set; }
        public class ListChatRecordDetailResponseBodyResultData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public long? TotalResults { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public long? OnePageSize { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListChatRecordDetailResponseBodyResultDataData> Data { get; set; }
            public class ListChatRecordDetailResponseBodyResultDataData : TeaModel {
                public string ServicerName { get; set; }
                public long? StartTime { get; set; }
                public long? EndTime { get; set; }
                public List<ListChatRecordDetailResponseBodyResultDataDataMessageList> MessageList { get; set; }
                public class ListChatRecordDetailResponseBodyResultDataDataMessageList : TeaModel {
                    public string SenderName { get; set; }
                    public string Content { get; set; }
                    public long? SenderType { get; set; }
                    public long? CreateTime { get; set; }
                    public string MsgType { get; set; }
                }
            }
        };

        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
