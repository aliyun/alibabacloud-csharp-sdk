// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateLoadBalancerProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate this value. Ensure that the value is unique among all requests. Only ASCII characters are allowed.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the value of <b>RequestId</b> is used.**** <b>RequestId</b> of each request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// <para>The reason why deletion protection is enabled. The reason must be 2 to 128 characters in length, can contain letters, digits, periods (.), underscores (_), and hyphens (-), and must start with a letter.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when <b>DeletionProtectionEnabled</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Instance_Is_Bound_By_Acceleration_Instance</para>
        /// </summary>
        [NameInMap("DeletionProtectionReason")]
        [Validation(Required=false)]
        public string DeletionProtectionReason { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run, without sending the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the NLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-83ckzc8d4xlp8o****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The reason why the configuration read-only mode is enabled. The reason must be 2 to 128 characters in length, can contain letters, digits, periods (.), underscores (_), and hyphens (-), and must start with a letter.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ConsoleProtection</para>
        /// </summary>
        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the configuration read-only mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NonProtection</b>: disables the configuration read-only mode. In this case, you cannot set the <b>ModificationProtectionReason</b> parameter. If you specify <b>ModificationProtectionReason</b>, the value is cleared.</description></item>
        /// <item><description><b>ConsoleProtection</b>: enables the configuration read-only mode. In this case, you can specify <b>ModificationProtectionReason</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>ConsoleProtection</b>, you cannot use the NLB console to modify configurations of the NLB instance. However, you can call API operations to modify the instance configurations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ConsoleProtection</para>
        /// </summary>
        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        /// <summary>
        /// <para>The region ID of the NLB instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
