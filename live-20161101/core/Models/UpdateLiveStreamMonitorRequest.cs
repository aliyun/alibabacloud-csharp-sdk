// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveStreamMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the output stream of the monitoring session belongs. You can specify a name. If you do not specify a name, the system uses <b>monitor</b> as the name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monitor****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The callback URL. Supported formats include HTTP and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/notify">http://guide.aliyundoc.com/notify</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The URL of the DingTalk chatbot. Specify a DingTalk chatbot that you have configured, and you can receive live monitoring alerts from the chatbot. For more information, see <a href="https://open.dingtalk.com/document/robots/custom-robot-access">Configure a custom chatbot</a>.</para>
        /// <remarks>
        /// <para> Specify &quot;Alert&quot; as the custom keyword of the DingTalk chatbot. Otherwise, you cannot receive messages.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa">https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa</a>****</para>
        /// </summary>
        [NameInMap("DingTalkWebHookUrl")]
        [Validation(Required=false)]
        public string DingTalkWebHookUrl { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The list of input streams to monitor. For more information, see the following <b>InputConfig</b> table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputConfig</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The monitoring alert thresholds. The value is a JSON string. For more information, see the following MonitorConfig table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;fpsLowThres\&quot;: 0.6,\&quot;brLowThres\&quot;: 1.1,\&quot;eofDurationThresSec\&quot;: 10}&quot;</para>
        /// </summary>
        [NameInMap("MonitorConfig")]
        [Validation(Required=false)]
        public string MonitorConfig { get; set; }

        /// <summary>
        /// <para>The ID of the monitoring session.</para>
        /// <remarks>
        /// <para> You can obtain the monitoring session ID from the response of the <a href="https://help.aliyun.com/document_detail/2848129.html">CreateLiveStreamMonitor</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("MonitorId")]
        [Validation(Required=false)]
        public string MonitorId { get; set; }

        /// <summary>
        /// <para>The name of the monitoring session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveMonitor****</para>
        /// </summary>
        [NameInMap("MonitorName")]
        [Validation(Required=false)]
        public string MonitorName { get; set; }

        /// <summary>
        /// <para>The output template of the monitoring session. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lp_ld</b>: low definition</description></item>
        /// <item><description><b>lp_sd</b>: standard definition</description></item>
        /// <item><description><b>lp_hd</b>: high definition</description></item>
        /// <item><description><b>lp_ud</b>: ultra-high definition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lp_ud</para>
        /// </summary>
        [NameInMap("OutputTemplate")]
        [Validation(Required=false)]
        public string OutputTemplate { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the output stream of the monitoring session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monitorStream****</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
