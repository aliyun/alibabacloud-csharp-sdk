// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClusterStateChangeReason : TeaModel {
        /// <summary>
        /// 状态码。取值范围：
        /// - UserRequest：用户请求。
        /// - OutOfStock：请求的ECS实例类型无库存。
        /// - NotAuthorized：无权限。
        /// - QuotaExceeded：Quota超出。
        /// - OperationDenied：操作被拒绝。
        /// - AccountException：账号异常。
        /// - NodeFailure：ECS节点异常。
        /// - BootstrapFailure：引导失败。
        /// - ValidationFail：业务逻辑校验失败。
        /// - ServiceFailure：依赖的其他服务失败。
        /// - InternalError：内部错误。
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 状态变化信息。
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
