// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of Success indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Agent data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentResponseBodyData Data { get; set; }
        public class GetAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent account name, which is the phone number or mailbox entered during account registration. Unique within the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>Agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222222</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>Agent display name shown externally.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX测试</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Skill group information to which the agent belongs.</para>
            /// </summary>
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyDataGroupList> GroupList { get; set; }
            public class GetAgentResponseBodyDataGroupList : TeaModel {
                /// <summary>
                /// <para>Skill group channel type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                /// <summary>
                /// <para>Skill group description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自动化技能组</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Display name of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自动化技能组</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>Skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自动化技能组</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public long? SkillGroupId { get; set; }

            }

            /// <summary>
            /// <para>Agent status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Normal</description></item>
            /// <item><description><b>1</b>: Freeze</description></item>
            /// <item><description><b>2</b>: Delete</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only agents with a Normal status can perform Business Activities.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Tenant ID to which the agent belongs, corresponding to the instance ID in the request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API invocation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
