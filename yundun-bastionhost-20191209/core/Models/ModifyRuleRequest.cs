// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyRuleRequest : TeaModel {
        /// <summary>
        /// <para>The new remarks for the authorization rule. The remarks can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The new list of database instances and database accounts associated with the authorization rule.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ModifyRuleRequestDatabases> Databases { get; set; }
        public class ModifyRuleRequestDatabases : TeaModel {
            /// <summary>
            /// <para>The list of database account IDs.</para>
            /// </summary>
            [NameInMap("DatabaseAccountIds")]
            [Validation(Required=false)]
            public List<string> DatabaseAccountIds { get; set; }

            /// <summary>
            /// <para>The database instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

        }

        /// <summary>
        /// <para>The new end time of the validity period for the authorization rule. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672502400</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public long? EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The new start time of the validity period for the authorization rule. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669630029</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public long? EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The new list of asset groups and accounts associated with the authorization rule.</para>
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<ModifyRuleRequestHostGroups> HostGroups { get; set; }
        public class ModifyRuleRequestHostGroups : TeaModel {
            /// <summary>
            /// <para>The list of asset account names.</para>
            /// </summary>
            [NameInMap("HostAccountNames")]
            [Validation(Required=false)]
            public List<string> HostAccountNames { get; set; }

            /// <summary>
            /// <para>The asset group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

        }

        /// <summary>
        /// <para>The new array of host IDs and host account IDs associated with the authorization rule.</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ModifyRuleRequestHosts> Hosts { get; set; }
        public class ModifyRuleRequestHosts : TeaModel {
            /// <summary>
            /// <para>The list of host account IDs.</para>
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
        /// <para>The ID of the Bastionhost instance to which the authorization rule to be updated belongs. &gt; You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-zmb2y9ydw08</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance to which the authorization rule to be updated belongs. &gt; For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the authorization rule to be updated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The new name of the authorization rule. The name must be 1 to 128 characters in length and cannot start with a special character. It can contain only periods (.), underscores (_), hyphens (-), single quotation marks (\&quot;), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The new list of user group IDs associated with the authorization rule.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The new list of user IDs associated with the authorization rule.</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
