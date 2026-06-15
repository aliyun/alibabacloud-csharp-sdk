// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetServiceIdentityRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>关联策略。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;Version&quot;: &quot;1&quot;,
        /// &quot;Statement&quot;:[]
        /// }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F629E92-F64D-502D-85AA-A9C54894CA3D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>服务账户角色名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForPaiFeatureStore</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
