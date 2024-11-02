// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateLoadBalancerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: performs a dry run and sends the request. If the request passes the dry run, a <c>2xx HTTP</c> status code is returned and the operation is performed. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the ALB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-o9ulmq5hgn68jk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the ALB instance. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-instance-test</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The configuration read-only mode.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public UpdateLoadBalancerAttributeRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class UpdateLoadBalancerAttributeRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>It must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
            /// <para>This parameter takes effect only when <b>ModificationProtectionStatus</b> is set to <b>ConsoleProtection</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the configuration read-only mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NonProtection</b>: disables the configuration read-only mode. In this case, you cannot specify <b>ModificationProtectionReason</b>. If you specify <b>ModificationProtectionReason</b>, the value of the parameter is cleared.</description></item>
            /// <item><description><b>ConsoleProtection</b>: enables the configuration read-only mode. In this case, you can specify <b>ModificationProtectionReason</b>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you set this parameter to <b>ConsoleProtection</b>, you cannot use the ALB console to modify instance configurations. However, you can call API operations to modify instance configurations.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ConsoleProtection</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
