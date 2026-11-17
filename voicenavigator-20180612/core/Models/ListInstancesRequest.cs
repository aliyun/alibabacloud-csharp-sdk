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
        /// <para>The filter condition for the scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The NLU type and the filter condition for the source of dialog capabilities. If you do not specify this parameter, all types are selected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MANAGED: <b>[Deprecated]</b> Managed.</para>
        /// </description></item>
        /// <item><description><para>AUTHORIZED: Authorized. Public cloud: Chatbot service.</para>
        /// </description></item>
        /// <item><description><para>PROVIDED: Private. Configured by specifying the AccessKey ID, AccessKey secret, and chatEndpoint in the O&amp;M console.</para>
        /// </description></item>
        /// <item><description><para>CCC_AUTHORIZED: Uses Chatbot authorized by Cloud Call Center.</para>
        /// </description></item>
        /// <item><description><para>CCC_FUNCTION: Uses Alibaba Cloud Function Compute.</para>
        /// </description></item>
        /// <item><description><para>SSE_FUNCTION: Uses streaming function services. Supports Function Compute with Server-Sent Events (SSE) for integrating third-party large language model chatbots.</para>
        /// </description></item>
        /// <item><description><para>PROMPTS: Integrates with foundation models such as Qwen.</para>
        /// </description></item>
        /// <item><description><para>LOCAL: Apsara Stack. Local Chatbot.</para>
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
        /// <para>The filter condition for the inbound number.</para>
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
        /// <para>The filter condition for the current scenario status. If you do not specify this parameter, all statuses are selected by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DISABLED: Offline.</description></item>
        /// <item><description>PUBLISHED: Published.</description></item>
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
        /// <para>If UnionSource is set to CCC, set UnionInstanceId to the instance ID of Cloud Call Center.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zhyl</para>
        /// </summary>
        [NameInMap("UnionInstanceId")]
        [Validation(Required=false)]
        public string UnionInstanceId { get; set; }

        /// <summary>
        /// <para>The source. Valid values:</para>
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
