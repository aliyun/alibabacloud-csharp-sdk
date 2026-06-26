// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>A JSON-formatted string that contains a list of digital worker instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;e4bebxxxxxxxxxxx&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIdListJsonString")]
        [Validation(Required=false)]
        public string InstanceIdListJsonString { get; set; }

        /// <summary>
        /// <para>The instance name. This parameter is used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The NLU service type. This parameter is used to filter instances by the source of their conversational AI capabilities. If you do not set this parameter, instances of all types are returned.</para>
        /// <list type="bullet">
        /// <item><description><para><c>MANAGED</c>: managed. This value is deprecated.</para>
        /// </description></item>
        /// <item><description><para><c>AUTHORIZED</c>: authorized. In the public cloud, this indicates the Chatbot service.</para>
        /// </description></item>
        /// <item><description><para><c>PROVIDED</c>: private. This service is configured in the console with parameters such as <c>as</c>, <c>sk</c>, and <c>chatEndpoint</c>.</para>
        /// </description></item>
        /// <item><description><para><c>CCC_AUTHORIZED</c>: a chatbot authorized by Cloud Connect Center (CCC).</para>
        /// </description></item>
        /// <item><description><para><c>CCC_FUNCTION</c>: Alibaba Cloud Function Compute.</para>
        /// </description></item>
        /// <item><description><para><c>SSE_FUNCTION</c>: a streaming function service. This refers to a Function Compute instance that supports Server-Sent Events (SSE) for integration with third-party large language model (LLM) chatbots.</para>
        /// </description></item>
        /// <item><description><para><c>PROMPTS</c>: integration with foundational models such as Qwen.</para>
        /// </description></item>
        /// <item><description><para><c>LOCAL</c>: a private cloud instance of Chatbot.</para>
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
        /// <para>The inbound number. This parameter is used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>021xxxxxxx</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The instance status. This parameter is used for filtering. If you do not set this parameter, instances in all statuses are returned.</para>
        /// <list type="bullet">
        /// <item><description><para><c>DISABLED</c>: disabled</para>
        /// </description></item>
        /// <item><description><para><c>PUBLISHED</c>: published</para>
        /// </description></item>
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
        /// <para>If you set <c>UnionSource</c> to <c>CCC</c>, set this parameter to the ID of your CCC instance.</para>
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
        /// <item><description><c>CCC</c>: Cloud Connect Center</description></item>
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
