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
        /// <para>You can generate the parameter value on your client. Make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: sends a check request without modifying the property of the application load balancing instance. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, an <c>HTTP_2xx</c> status code is returned and the operation is directly performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the application load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-o9ulmq5hgn68jk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the Application Load Balancer instance. The name must be 2 to 128 characters in length and start with a letter, Chinese character, or digit. It can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-instance-test</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The modification protection configuration.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public UpdateLoadBalancerAttributeRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class UpdateLoadBalancerAttributeRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The reason for enabling modification protection. The value must be 2 to 128 characters in length. It must start with a letter or Chinese character and can contain digits, periods (.), underscores (_), and hyphens (-). This parameter is valid only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Managed Instance</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The modification protection status of the application load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NonProtection</b>: disables modification protection. If <b>Reason</b> is specified, it is forcibly cleared.</para>
            /// </description></item>
            /// <item><description><para><b>ConsoleProtection</b>: enables console modification protection. If <b>Reason</b> is specified, it takes effect.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If this parameter is set to <b>ConsoleProtection</b>, modification protection is enabled. In this case, you cannot modify the instance configurations in the load balancing console, but you can invoke API operations to modify the instance configurations.</para>
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
