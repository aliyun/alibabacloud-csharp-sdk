// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListSchedulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the flow that is associated with the time-based schedules. The name is unique within the region and cannot be modified after the flow is created. The name must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>The name is case-sensitive.</description></item>
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testFlowName</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The number of schedules that you want to query. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>For the first query, you do not need to specify this parameter. The system uses the value of the <b>FlowName</b> parameter as the value of the <b>NextToken</b> parameter. When the query ends, no value is returned for this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNextToken</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
