// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesRequest : TeaModel {
        /// <summary>
        /// <para>The direction to which the forwarding rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Request</b> (default): The forwarding rule is applied to the client requests received by ALB.</description></item>
        /// <item><description><b>Response</b>: The forwarding rule is applied to the responses returned by backend servers.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You cannot set this parameter to Response if you use basic ALB instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Request</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The listener IDs.</para>
        /// </summary>
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

        /// <summary>
        /// <para>The Application Load Balancer (ALB) instance IDs.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// <para>Valid values: <b>1 to 100</b>.</para>
        /// <para>Default value: <b>20</b>. If you do not specify this parameter, the default value is used.</para>
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
        /// <para>The starting point of the current query. If you do not specify this parameter, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The forwarding rules.</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<string> RuleIds { get; set; }

        /// <summary>
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListRulesRequestTag> Tag { get; set; }
        public class ListRulesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
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
