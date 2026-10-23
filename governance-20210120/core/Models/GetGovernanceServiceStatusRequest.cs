// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetGovernanceServiceStatusRequest : TeaModel {
        /// <summary>
        /// <para>必填。待操作或查询的地域 ID，必须为服务支持的合法地域，且与本次调用 endpoint 对应的地域一致；不提供隐式默认地域。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
