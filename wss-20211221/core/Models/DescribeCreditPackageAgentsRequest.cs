// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeCreditPackageAgentsRequest : TeaModel {
        /// <summary>
        /// <para>An array of agent IDs to query. Example: <c>[&quot;agent-1&quot;,&quot;agent-2&quot;]</c>.</para>
        /// </summary>
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public List<string> AgentIds { get; set; }

        /// <summary>
        /// <para>The agent type. Valid values: <c>CREDIT_PACKAGE</c>, <c>JVS_CLAW</c>, <c>OPEN_CLAW</c>, and <c>JVS_COPILOT</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JVS_COPILOT</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUSINESS</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. Obtain this value from the <c>NextToken</c> parameter of the previous response. For the first request, set this parameter to an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
