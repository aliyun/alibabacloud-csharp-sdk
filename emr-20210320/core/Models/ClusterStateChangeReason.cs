// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClusterStateChangeReason : TeaModel {
        /// <summary>
        /// <para>状态码。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>UserRequest：用户请求。</description></item>
        /// <item><description>OutOfStock：请求的ECS实例类型无库存。</description></item>
        /// <item><description>NotAuthorized：无权限。</description></item>
        /// <item><description>QuotaExceeded：Quota超出。</description></item>
        /// <item><description>OperationDenied：操作被拒绝。</description></item>
        /// <item><description>AccountException：账号异常。</description></item>
        /// <item><description>NodeFailure：ECS节点异常。</description></item>
        /// <item><description>BootstrapFailure：引导失败。</description></item>
        /// <item><description>ValidationFail：业务逻辑校验失败。</description></item>
        /// <item><description>ServiceFailure：依赖的其他服务失败。</description></item>
        /// <item><description>InternalError：内部错误。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OutOfStock</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>状态变化信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource is sold out in the specified zone, try other types of resources or other regions and zones.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
