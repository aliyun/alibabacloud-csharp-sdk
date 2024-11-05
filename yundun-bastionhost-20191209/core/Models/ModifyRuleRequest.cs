// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyRuleRequest : TeaModel {
        /// <summary>
        /// <para>The new remarks of the authorization rule. It can be up to 500 characters in length.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The databases and database accounts that a user associated with the modified rule can manage.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ModifyRuleRequestDatabases> Databases { get; set; }
        public class ModifyRuleRequestDatabases : TeaModel {
            /// <summary>
            /// <para>The database account IDs.</para>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;DatabaseId&quot;: &quot;1&quot;
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        /// <summary>
        /// <para>The end time of the new validity period of the authorization rule. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672502400</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public long? EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the new validity period of the authorization rule. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669630029</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public long? EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The asset groups and asset accounts that a user associated with the modified rule can manage.</para>
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<ModifyRuleRequestHostGroups> HostGroups { get; set; }
        public class ModifyRuleRequestHostGroups : TeaModel {
            /// <summary>
            /// <para>The names of the asset accounts.</para>
            /// </summary>
            [NameInMap("HostAccountNames")]
            [Validation(Required=false)]
            public List<string> HostAccountNames { get; set; }

            /// <summary>
            /// <para>The asset group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;HostGroupId&quot;:&quot;1&quot;}]</para>
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the host IDs and host account IDs with which the modified authorization rule is associated.</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ModifyRuleRequestHosts> Hosts { get; set; }
        public class ModifyRuleRequestHosts : TeaModel {
            /// <summary>
            /// <para>The host account IDs.</para>
            /// </summary>
            [NameInMap("HostAccountIds")]
            [Validation(Required=false)]
            public List<string> HostAccountIds { get; set; }

            /// <summary>
            /// <para>The host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;HostId&quot;:&quot;1&quot;}]</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the bastion host whose authorization rule you want to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-zmb2y9ydw08</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host to which the authorization rule to modify belongs.</para>
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
        /// <para>The ID of the authorization rule to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The new name of the authorization rule. The name must be 1 to 128 characters in length and can contain periods (.), underscores (_), hyphens (-), single quotation marks (\&quot;), and spaces. It cannot start with a special character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups with which the modified authorization rule is associated.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of the users with whom the modified authorization rule is associated.</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
