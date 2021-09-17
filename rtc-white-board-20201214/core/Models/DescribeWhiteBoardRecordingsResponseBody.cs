// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class DescribeWhiteBoardRecordingsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 返回结果体
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeWhiteBoardRecordingsResponseBodyResult Result { get; set; }
        public class DescribeWhiteBoardRecordingsResponseBodyResult : TeaModel {
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }
            [NameInMap("RecordingList")]
            [Validation(Required=false)]
            public List<DescribeWhiteBoardRecordingsResponseBodyResultRecordingList> RecordingList { get; set; }
            public class DescribeWhiteBoardRecordingsResponseBodyResultRecordingList : TeaModel {
                public string AppID { get; set; }
                public string DocKey { get; set; }
                public string RecordId { get; set; }
                public string UserId { get; set; }
                public List<string> OperateList { get; set; }
            }
        };

    }

}
