// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateRuleRequest : TeaModel {
        /// <summary>
        /// <para>The remarks of the authorization rule. The remarks can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The information about the database that runs on your server.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<CreateRuleRequestDatabases> Databases { get; set; }
        public class CreateRuleRequestDatabases : TeaModel {
            /// <summary>
            /// <para>An array that consists of database account IDs.</para>
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
        /// <para>The end time of the validity period of the authorization rule. Specify a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672502400</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public long? EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the validity period of the authorization rule. Specify a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669630029</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public long? EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The information about the asset group that you want to authorize to manage.</para>
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<CreateRuleRequestHostGroups> HostGroups { get; set; }
        public class CreateRuleRequestHostGroups : TeaModel {
            /// <summary>
            /// <para>An array that consists of asset account names.</para>
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
        /// <para>The host information.</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<CreateRuleRequestHosts> Hosts { get; set; }
        public class CreateRuleRequestHosts : TeaModel {
            /// <summary>
            /// <para>An array that consists of host account IDs.</para>
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
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-5yd2ymfsa0e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The name of the authorization rule. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>An array that consists of user group IDs.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>An array that consists of user IDs.</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
