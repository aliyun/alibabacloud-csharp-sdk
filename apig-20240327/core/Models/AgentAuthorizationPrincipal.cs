// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentAuthorizationPrincipal : TeaModel {
        /// <summary>
        /// <para>The ID of the authorization principal. Specify a consumer ID or consumer group ID based on the value of principalType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer-1</para>
        /// </summary>
        [NameInMap("principalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the authorization principal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Consumer: consumer.</description></item>
        /// <item><description>ConsumerGroup: consumer group.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Consumer</para>
        /// </summary>
        [NameInMap("principalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

    }

}
