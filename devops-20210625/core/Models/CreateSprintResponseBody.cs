// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateSprintResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 迭代信息
        /// </summary>
        [NameInMap("sprint")]
        [Validation(Required=false)]
        public CreateSprintResponseBodySprint Sprint { get; set; }
        public class CreateSprintResponseBodySprint : TeaModel {
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }
            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public long? StartDate { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
