// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// 工作空间信息
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public GetWorkspaceResponseBodyWorkspace Workspace { get; set; }
        public class GetWorkspaceResponseBodyWorkspace : TeaModel {
            [NameInMap("codeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }
            [NameInMap("codeUrl")]
            [Validation(Required=false)]
            public string CodeUrl { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
        };

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

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

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
