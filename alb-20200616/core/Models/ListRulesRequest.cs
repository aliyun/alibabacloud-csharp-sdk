// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesRequest : TeaModel {
        /// <summary>
        /// <para>The direction of the forwarding rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Request</b> (default): The forwarding rule is applied to requests. Application Load Balancer (ALB) matches conditions in the requests sent from clients and performs the specified actions.</para>
        /// </description></item>
        /// <item><description><para><b>Response</b>: The forwarding rule is applied to responses. ALB matches conditions in the responses sent from backend servers and performs the specified actions.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Basic ALB instances do not support the Response type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Request</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The listener IDs. You can specify up to 20 listener IDs.</para>
        /// </summary>
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

        /// <summary>
        /// <para>The SLB instance IDs. You can specify up to 20 instance IDs.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// <para>Valid values: 1 to <b>100</b>.</para>
        /// <para>Default value: <b>20</b>.</para>
        /// <remarks>
        /// <para>This parameter is optional.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>You do not need to set this parameter for the first query.</para>
        /// </description></item>
        /// <item><description><para>For a subsequent query, set this parameter to the value of <b>NextToken</b> from the previous response.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The IDs of the forwarding rules. You can specify up to 20 forwarding rule IDs.</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<string> RuleIds { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListRulesRequestTag> Tag { get; set; }
        public class ListRulesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length. It cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c>, and cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length. It cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c>, and cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
