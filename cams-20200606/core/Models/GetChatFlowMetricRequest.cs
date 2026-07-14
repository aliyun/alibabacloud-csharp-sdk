// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatFlowMetricRequest : TeaModel {
        /// <summary>
        /// <para>The business tenant code. Default value: ALICOM_OPAAS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The business extension information. Default value: an empty collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizExtend { get; set; }

        /// <summary>
        /// <para>The flow code. You can view the flow code on the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The flow version. On the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page, click the flow name to open the canvas and view the flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

        /// <summary>
        /// <para>The start time. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751299200</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The metric name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>nodeUsageStatistics: node usage statistics.</para>
        /// </description></item>
        /// <item><description><para>nodeErrorDetails: node error details.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodeUsageStatistics</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The extended parameter for the metric query. When MetricName is set to nodeErrorDetails, pass in a JSON string. Valid values for the JSON fields:</para>
        /// <list type="bullet">
        /// <item><description><para>pageNo: the current page number.</para>
        /// </description></item>
        /// <item><description><para>pageSize: the number of entries per page.</para>
        /// </description></item>
        /// <item><description><para>nodeId: the node ID. On the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page, click the flow name to open the canvas and copy the node ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;pageNo&quot;: 1,
        ///   &quot;pageSize&quot;: 20,
        ///   &quot;nodeId&quot;: &quot;SendWhatsAppMessage#H7fKq5rM&quot;
        /// }</para>
        /// </summary>
        [NameInMap("MetricParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> MetricParam { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The end time. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751385599</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
