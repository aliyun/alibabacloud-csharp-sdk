// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSkillGroupAgentStatusDetailsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID，用于跟踪错误原因
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillGroupAgentStatusDetailsResponseBodyData Data { get; set; }
        public class GetSkillGroupAgentStatusDetailsResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }
        };

    }

}
