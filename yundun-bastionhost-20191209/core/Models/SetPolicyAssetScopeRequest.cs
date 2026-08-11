// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyAssetScopeRequest : TeaModel {
        /// <summary>
        /// <para>The databases to which the control policy applies.</para>
        /// <remarks>
        /// <para>Required when ScopeType is set to Database. A maximum of 500 databases can be specified.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestDatabases> Databases { get; set; }
        public class SetPolicyAssetScopeRequestDatabases : TeaModel {
            /// <summary>
            /// <para>The scope of database accounts to which the control policy applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: applies to all accounts in the database.</description></item>
            /// <item><description><b>AccountId</b>: applies to specified accounts in the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AccountId</para>
            /// </summary>
            [NameInMap("AccountScopeType")]
            [Validation(Required=false)]
            public string AccountScopeType { get; set; }

            /// <summary>
            /// <para>The database accounts to which the control policy applies.</para>
            /// <remarks>
            /// <para>Required when AccountScopeType is set to AccountId.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The database instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        /// <summary>
        /// <para>The asset groups to which the control policy applies.</para>
        /// <remarks>
        /// <para>Required when ScopeType is set to HostGroup. A maximum of 100 asset groups can be specified.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestHostGroups> HostGroups { get; set; }
        public class SetPolicyAssetScopeRequestHostGroups : TeaModel {
            /// <summary>
            /// <para>The asset accounts to which the control policy applies.</para>
            /// <remarks>
            /// <para>Required when AccountScopeType is set to AccountNames.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AccountNames")]
            [Validation(Required=false)]
            public List<string> AccountNames { get; set; }

            /// <summary>
            /// <para>The scope of asset accounts to which the control policy applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: applies to all accounts in the asset group.</description></item>
            /// <item><description><b>AccountName</b>: applies to specified accounts in the asset group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("AccountScopeType")]
            [Validation(Required=false)]
            public string AccountScopeType { get; set; }

            /// <summary>
            /// <para>The asset group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

        }

        /// <summary>
        /// <para>The hosts to which the control policy applies.</para>
        /// <remarks>
        /// <para>Required when ScopeType is set to Host. A maximum of 500 hosts can be specified.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestHosts> Hosts { get; set; }
        public class SetPolicyAssetScopeRequestHosts : TeaModel {
            /// <summary>
            /// <para>The scope of host accounts to which the control policy applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: applies to all accounts on the host.</description></item>
            /// <item><description><b>AccountId</b>: applies to specified accounts on the host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("AccountScopeType")]
            [Validation(Required=false)]
            public string AccountScopeType { get; set; }

            /// <summary>
            /// <para>The host accounts to which the control policy applies.</para>
            /// <remarks>
            /// <para>Required when AccountScopeType is set to AccountId.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("HostAccountIds")]
            [Validation(Required=false)]
            public List<string> HostAccountIds { get; set; }

            /// <summary>
            /// <para>The host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the bastion host.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>The ID of the control policy to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> operation to obtain this parameter.</para>
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
        /// <para>The project ID.</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The asset scope for the control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: applies to all assets.</description></item>
        /// <item><description><b>Host</b>: applies to selected hosts.</description></item>
        /// <item><description><b>Database</b>: applies to selected databases.</description></item>
        /// <item><description><b>HostGroup</b>: applies to selected asset groups.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
