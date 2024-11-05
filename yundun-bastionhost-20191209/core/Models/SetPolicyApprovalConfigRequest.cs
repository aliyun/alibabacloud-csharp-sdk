// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyApprovalConfigRequest : TeaModel {
        /// <summary>
        /// <para>The O&amp;M approval setting in the control policy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApprovalConfig")]
        [Validation(Required=false)]
        public SetPolicyApprovalConfigRequestApprovalConfig ApprovalConfig { get; set; }
        public class SetPolicyApprovalConfigRequestApprovalConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable O&amp;M approval in the control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>On</b>: enables O&amp;M approval.</description></item>
            /// <item><description><b>Off</b>: disables O&amp;M approval.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>On</para>
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

        }

        /// <summary>
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the control policy that you want to modify.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> operation to query the control policy ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
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
