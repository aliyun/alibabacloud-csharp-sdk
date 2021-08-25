// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class DeleteRepositoryMemberWithExternUidResponseBody : TeaModel {
        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteRepositoryMemberWithExternUidResponseBodyResult Result { get; set; }
        public class DeleteRepositoryMemberWithExternUidResponseBodyResult : TeaModel {
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("AccessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

    }

}
