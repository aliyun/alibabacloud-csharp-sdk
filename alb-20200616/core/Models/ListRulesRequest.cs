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
        /// <item><description><para><b>Request</b> (default): request type. Performs condition matching and corresponding processing on packets sent from the client to ALB.</para>
        /// </description></item>
        /// <item><description><para><b>Response</b>: response type. Performs condition matching and corresponding processing on packets returned from backend server groups to ALB.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>ALB Basic Edition instances do not support the Response type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Request</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The list of listener IDs. You can query up to 20 listeners at a time.</para>
        /// </summary>
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

        /// <summary>
        /// <para>The list of load balancing instance IDs. You can query up to 20 instances at a time.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to read in this request.</para>
        /// <para>Valid values: <b>1 to 100</b>.</para>
        /// <para>Default value: <b>20</b>, which indicates that no value is specified.</para>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>You do not need to specify this parameter for the first request or if no next query exists.</para>
        /// </description></item>
        /// <item><description><para>If a next query exists, set the value to the <b>NextToken</b> value returned in the previous API call.</para>
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
        /// <para>The list of forwarding rules. You can query up to 20 forwarding rules at a time.</para>
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
            /// <para>The tag key. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
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
