// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetFlowTagGroupResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("flowTagGroup")]
        [Validation(Required=false)]
        public GetFlowTagGroupResponseBodyFlowTagGroup FlowTagGroup { get; set; }
        public class GetFlowTagGroupResponseBodyFlowTagGroup : TeaModel {
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }
            [NameInMap("flowTagList")]
            [Validation(Required=false)]
            public List<GetFlowTagGroupResponseBodyFlowTagGroupFlowTagList> FlowTagList { get; set; }
            public class GetFlowTagGroupResponseBodyFlowTagGroupFlowTagList : TeaModel {
                public string Color { get; set; }
                public string CreatorAccountId { get; set; }
                public long? Id { get; set; }
                public string ModiferAccountId { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("modiferAccountId")]
            [Validation(Required=false)]
            public string ModiferAccountId { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
