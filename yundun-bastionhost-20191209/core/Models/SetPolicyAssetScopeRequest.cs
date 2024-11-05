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
        /// <para> This parameter is required if ScopeType is set to Database. You can specify up to 500 databases.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestDatabases> Databases { get; set; }
        public class SetPolicyAssetScopeRequestDatabases : TeaModel {
            /// <summary>
            /// <para>The scope of database accounts to which the control policy applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: The control policy applies to all database accounts of the database.</description></item>
            /// <item><description><b>AccountId</b>: The control policy applies to specified database accounts of the database.</description></item>
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
            /// <para> This parameter is required if AccountScopeType is set to AccountId.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
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
        /// <para>This parameter is required if ScopeType is set to HostGroup. You can specify up to 100 asset groups.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestHostGroups> HostGroups { get; set; }
        public class SetPolicyAssetScopeRequestHostGroups : TeaModel {
            /// <summary>
            /// <para>The asset accounts to which the control policy applies.</para>
            /// <remarks>
            /// <para>This parameter is required if AccountScopeType is set to AccountName.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AccountNames")]
            [Validation(Required=false)]
            public List<string> AccountNames { get; set; }

            /// <summary>
            /// <para>The scope of asset accounts to which the control policy applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: The control policy applies to all accounts in the asset group.</description></item>
            /// <item><description><b>AccountName</b>: The control policy applies to specified accounts in the asset group.</description></item>
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
        /// <para>This parameter is required if ScopeType is set to Host. You can specify up to 500 hosts.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<SetPolicyAssetScopeRequestHosts> Hosts { get; set; }
        public class SetPolicyAssetScopeRequestHosts : TeaModel {
            /// <summary>
            /// <para>The scope of host accounts to which the control policy applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All</b>: The control policy applies to all accounts of the host.</description></item>
            /// <item><description><b>AccountId</b>: The control policy applies specified accounts of the host.</description></item>
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
            /// <para>This parameter is required if AccountScopeType is set to AccountId.</para>
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
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
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
        /// <para>The scope of assets to which the control policy applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: The control policy applies to all assets.</description></item>
        /// <item><description><b>Host</b>: The control policy applies to specified hosts.</description></item>
        /// <item><description><b>Database</b>: The control policy applies to specified databases.</description></item>
        /// <item><description><b>HostGroup</b>: The control policy applies to specified asset groups.</description></item>
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
