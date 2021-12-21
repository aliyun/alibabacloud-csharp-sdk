// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeCallUserExpResponseBody : TeaModel {
        /// <summary>
        /// 通信体验信息。
        /// </summary>
        [NameInMap("ExpInfoList")]
        [Validation(Required=false)]
        public List<DescribeCallUserExpResponseBodyExpInfoList> ExpInfoList { get; set; }
        public class DescribeCallUserExpResponseBodyExpInfoList : TeaModel {
            /// <summary>
            /// 用户体验：GOOD:优良, BAD:欠佳
            /// </summary>
            [NameInMap("CallExp")]
            [Validation(Required=false)]
            public string CallExp { get; set; }

            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
