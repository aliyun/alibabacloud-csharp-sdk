// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListHotlineRecordDetailResponseBody : TeaModel {
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
        public ListHotlineRecordDetailResponseBodyResultData ResultData { get; set; }
        public class ListHotlineRecordDetailResponseBodyResultData : TeaModel {
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
            public List<ListHotlineRecordDetailResponseBodyResultDataData> Data { get; set; }
            public class ListHotlineRecordDetailResponseBodyResultDataData : TeaModel {
                public string ServicerName { get; set; }
                public long? StartTime { get; set; }
                public long? EndTime { get; set; }
                public string OssUrl { get; set; }
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
