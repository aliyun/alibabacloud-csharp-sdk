// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateLoadBalancerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. Make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <para>Generate a value from your client and make sure that the value is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
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
        /// <item><description><para><b>true</b>: Performs a dry run. The system checks for required parameters, the request format, and business limits. If the request fails the check, an error message is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned. No properties of the Application Load Balancer instance are modified.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request. After the request passes the check, a <c>2xx</c> status code is returned and the operation is performed.</para>
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
        /// <para>The Application Load Balancer instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-o9ulmq5hgn68jk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the Application Load Balancer instance must be 2 to 128 characters in length. It must start with a letter, a Chinese character, or a number. The name can contain numbers, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-instance-test</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The modification protection settings.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public UpdateLoadBalancerAttributeRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class UpdateLoadBalancerAttributeRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The reason for enabling modification protection.</para>
            /// <para>The reason must be 2 to 128 characters long. It must start with a letter and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
            /// <para>This parameter is valid only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Managed Instance</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The modification protection status of the Application Load Balancer instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NonProtection</b>: Disables modification protection. If you specify a value for <b>Reason</b>, the value is cleared.</para>
            /// </description></item>
            /// <item><description><para><b>ConsoleProtection</b>: Enables modification protection in the console. If you specify a value for <b>Reason</b>, the value takes effect.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If you set the value to <b>ConsoleProtection</b>, you cannot modify the instance configuration in the Application Load Balancer console. However, you can still modify the instance configuration by calling API operations.</para>
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
