// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyCommandConfigRequest : TeaModel {
        /// <summary>
        /// <para>The command control settings.</para>
        /// <remarks>
        /// <para>This parameter applies only to Linux hosts.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CommandConfig")]
        [Validation(Required=false)]
        public SetPolicyCommandConfigRequestCommandConfig CommandConfig { get; set; }
        public class SetPolicyCommandConfigRequestCommandConfig : TeaModel {
            /// <summary>
            /// <para>The command approval settings.</para>
            /// <remarks>
            /// <para>A command approval policy is used to approve the commands that are excluded from a whitelist or blacklist specified in a command control policy. The command control policy takes precedence over the command approval policy in validation.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Approval")]
            [Validation(Required=false)]
            public SetPolicyCommandConfigRequestCommandConfigApproval Approval { get; set; }
            public class SetPolicyCommandConfigRequestCommandConfigApproval : TeaModel {
                /// <summary>
                /// <para>The commands that can be run only after approval.</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

            }

            /// <summary>
            /// <para>The command control settings.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Deny")]
            [Validation(Required=false)]
            public SetPolicyCommandConfigRequestCommandConfigDeny Deny { get; set; }
            public class SetPolicyCommandConfigRequestCommandConfigDeny : TeaModel {
                /// <summary>
                /// <para>The type of command control. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>black</b>: blacklist mode.</description></item>
                /// <item><description><b>white</b>: whitelist mode.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>white</para>
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// <para>The commands to be controlled.</para>
                /// <remarks>
                /// <para>This parameter is required if AclType is set to white.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

            }

        }

        /// <summary>
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1ghxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the control policy that you want to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> operation to query the control policy ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
