// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetGroupByIdResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 群信息获取的返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetGroupByIdResponseBodyResult Result { get; set; }
        public class GetGroupByIdResponseBodyResult : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("OwnerAppUid")]
            [Validation(Required=false)]
            public string OwnerAppUid { get; set; }
            [NameInMap("IconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("MemberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }
            [NameInMap("MemberLimit")]
            [Validation(Required=false)]
            public int? MemberLimit { get; set; }
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }
            [NameInMap("CeateTime")]
            [Validation(Required=false)]
            public long? CeateTime { get; set; }
        };

    }

}
