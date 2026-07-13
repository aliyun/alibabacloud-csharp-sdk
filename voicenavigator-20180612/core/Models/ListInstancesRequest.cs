// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The list of digital employee scenario IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;e4bebxxxxxxxxxxx&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIdListJsonString")]
        [Validation(Required=false)]
        public string InstanceIdListJsonString { get; set; }

        /// <summary>
        /// <para>The scenario name used as a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The NLU type used to filter by dialog capability source. If this parameter is not specified, all types are selected.</para>
        /// <list type="bullet">
        /// <item><description><para>MANAGED: managed (deprecated).</para>
        /// </description></item>
        /// <item><description><para>AUTHORIZED: authorized. In the public cloud, this refers to Chatbot service.</para>
        /// </description></item>
        /// <item><description><para>PROVIDED: private. Configured by specifying the AccessKey ID, AccessKey Secret, and chatEndpoint in the O&amp;M console.</para>
        /// </description></item>
        /// <item><description><para>CCC_AUTHORIZED: uses a Chatbot authorized by Cloud Call Center.</para>
        /// </description></item>
        /// <item><description><para>CCC_FUNCTION: uses Alibaba Cloud Function Compute.</para>
        /// </description></item>
        /// <item><description><para>SSE_FUNCTION: uses a streaming function service. Function Compute that supports SSE, used to connect to third-party large language model chatbots.</para>
        /// </description></item>
        /// <item><description><para>PROMPTS: connects to Qwen foundation models.</para>
        /// </description></item>
        /// <item><description><para>LOCAL: private cloud, local Chatbot.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CCC_AUTHORIZED&quot;]</para>
        /// </summary>
        [NameInMap("NluServiceTypeListJsonString")]
        [Validation(Required=false)]
        public string NluServiceTypeListJsonString { get; set; }

        /// <summary>
        /// <para>The inbound number used as a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>021xxxxxxx</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scenario status used as a filter condition. If this parameter is not specified, all statuses are selected.</para>
        /// <list type="bullet">
        /// <item><description>DISABLED: offline.</description></item>
        /// <item><description>PUBLISHED: published.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>When UnionSource is set to CCC, set UnionInstanceId to the instance ID of Cloud Call Center.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zhyl</para>
        /// </summary>
        [NameInMap("UnionInstanceId")]
        [Validation(Required=false)]
        public string UnionInstanceId { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// <list type="bullet">
        /// <item><description>CCC: Cloud Call Center.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CCC</para>
        /// </summary>
        [NameInMap("UnionSource")]
        [Validation(Required=false)]
        public string UnionSource { get; set; }

    }

}
