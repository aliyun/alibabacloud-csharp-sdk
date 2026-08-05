// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveStreamMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The application name for the output stream of the monitoring session. You can specify a custom name. If you do not specify this parameter, <b>monitor</b> is used as the application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monitor****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The webhook address. HTTP and HTTPS are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/notify">http://guide.aliyundoc.com/notify</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The webhook URL of the DingTalk chatbot. To receive alert notifications, configure a DingTalk chatbot and enter its webhook URL, which can be in HTTP or HTTPS format. For more information, see <a href="https://open.dingtalk.com/document/robots/custom-robot-access">Custom robot access</a>.</para>
        /// <remarks>
        /// <para>Set the custom keyword for the DingTalk chatbot to &quot;Alerting&quot;. Otherwise, you cannot receive messages.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa">https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa</a>****</para>
        /// </summary>
        [NameInMap("DingTalkWebHookUrl")]
        [Validation(Required=false)]
        public string DingTalkWebHookUrl { get; set; }

        /// <summary>
        /// <para>The domain name to monitor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The list of input streams to monitor. For more information, see the <b>InputConfig</b> table below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputConfig</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The alert threshold settings for monitoring. The value must be a JSON string. For more information, see the MonitorConfig table below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;fpsLowThres\&quot;: 0.6,\&quot;brLowThres\&quot;: 1.1,\&quot;eofDurationThresSec\&quot;: 10}&quot;</para>
        /// </summary>
        [NameInMap("MonitorConfig")]
        [Validation(Required=false)]
        public string MonitorConfig { get; set; }

        /// <summary>
        /// <para>The name of the monitoring session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveMonitor****</para>
        /// </summary>
        [NameInMap("MonitorName")]
        [Validation(Required=false)]
        public string MonitorName { get; set; }

        /// <summary>
        /// <para>The output template for the monitoring session. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lp_ld</b>: low definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_sd</b>: standard definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_hd</b>: high definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_ud</b>: ultra-high definition.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the output stream for the monitoring session. If you do not specify this parameter, the system generates a random name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monitorStream****</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
