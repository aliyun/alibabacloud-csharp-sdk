// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyUserScopeRequest : TeaModel {
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scope of users to whom the control policy applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: The control policy applies to all users.</description></item>
        /// <item><description><b>User</b>: The control policy applies to specified users.</description></item>
        /// <item><description><b>UserGroup</b>: The control policy applies to specified user groups.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// <para>The user groups to which the control policy applies.</para>
        /// <remarks>
        /// <para>This parameter is required if ScopeType is set to UserGroup. You can specify up to 100 user group IDs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The users to whom the control policy applies.</para>
        /// <remarks>
        /// <para>This parameter is required if ScopeType is set to User. You can specify up to 500 user IDs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
