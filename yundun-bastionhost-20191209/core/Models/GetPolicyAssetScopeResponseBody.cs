// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetPolicyAssetScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The asset scope of the control policy.</para>
        /// </summary>
        [NameInMap("AssetScope")]
        [Validation(Required=false)]
        public GetPolicyAssetScopeResponseBodyAssetScope AssetScope { get; set; }
        public class GetPolicyAssetScopeResponseBodyAssetScope : TeaModel {
            /// <summary>
            /// <para>The list of database assets to which the control policy applies.</para>
            /// </summary>
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<GetPolicyAssetScopeResponseBodyAssetScopeDatabases> Databases { get; set; }
            public class GetPolicyAssetScopeResponseBodyAssetScopeDatabases : TeaModel {
                /// <summary>
                /// <para>The scope of database accounts to which the control policy applies. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>All</b>: The policy applies to all accounts in the database.</description></item>
                /// <item><description><b>AccountId</b>: The policy applies to specified accounts in the database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AccountId</para>
                /// </summary>
                [NameInMap("AccountScopeType")]
                [Validation(Required=false)]
                public string AccountScopeType { get; set; }

                /// <summary>
                /// <para>The list of database account IDs to which the control policy applies.</para>
                /// </summary>
                [NameInMap("DatabaseAccountIds")]
                [Validation(Required=false)]
                public List<string> DatabaseAccountIds { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

            }

            /// <summary>
            /// <para>The scope of asset groups to which the control policy applies.</para>
            /// </summary>
            [NameInMap("HostGroups")]
            [Validation(Required=false)]
            public List<GetPolicyAssetScopeResponseBodyAssetScopeHostGroups> HostGroups { get; set; }
            public class GetPolicyAssetScopeResponseBodyAssetScopeHostGroups : TeaModel {
                /// <summary>
                /// <para>The scope of asset accounts to which the control policy applies.</para>
                /// </summary>
                [NameInMap("AccountNames")]
                [Validation(Required=false)]
                public List<string> AccountNames { get; set; }

                /// <summary>
                /// <para>The scope of asset accounts to which the control policy applies. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>All</b>: The policy applies to all accounts in the asset group.</description></item>
                /// <item><description><b>AccountName</b>: The policy applies to specified accounts in the asset group.</description></item>
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
                /// <para>4</para>
                /// </summary>
                [NameInMap("HostGroupId")]
                [Validation(Required=false)]
                public string HostGroupId { get; set; }

            }

            /// <summary>
            /// <para>The scope of hosts to which the control policy applies.</para>
            /// </summary>
            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<GetPolicyAssetScopeResponseBodyAssetScopeHosts> Hosts { get; set; }
            public class GetPolicyAssetScopeResponseBodyAssetScopeHosts : TeaModel {
                /// <summary>
                /// <para>The scope of host accounts to which the control policy applies. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>All</b>: The policy applies to all accounts on the host.</description></item>
                /// <item><description><b>AccountId</b>: The policy applies to specified accounts on the host.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("AccountScopeType")]
                [Validation(Required=false)]
                public string AccountScopeType { get; set; }

                /// <summary>
                /// <para>The scope of host accounts to which the control policy applies.</para>
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
            /// <para>The asset scope of the control policy.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If <b>All</b> is returned, the control policy applies to all assets.</description></item>
            /// <item><description>If an empty value is returned, the policy applies to specified assets. The specific scope is indicated by the values returned for Databases, HostGroups, and Hosts.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

        }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
