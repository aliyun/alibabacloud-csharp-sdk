// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveStreamMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application that plays the output streams of the monitoring session.</para>
        /// <para>You can specify a name. If you do not specify a name, the system uses <b>monitor</b> as the name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monitor****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>Supports input of callback addresses in HTTP(S) format.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://guide.aliyundoc.com/notify">http://guide.aliyundoc.com/notify</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>DingTalk alert monitoring sends alert notifications through a DingTalk group robot. Please set up the DingTalk group robot first and enter the HTTP(S) address of the robot here. For more details, see <a href="https://open.dingtalk.com/document/robots/custom-robot-access">Custom Robot Access</a>.</para>
        /// <remarks>
        /// <para>Configure the custom keyword for the DingTalk group robot as \&quot;alert\&quot;, otherwise, messages will not be received.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa">https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa</a>****</para>
        /// </summary>
        [NameInMap("DingTalkWebHookUrl")]
        [Validation(Required=false)]
        public string DingTalkWebHookUrl { get; set; }

        /// <summary>
        /// <para>The endpoint of the monitoring session.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>Alarm threshold setting for monitoring, in JSON format. For more details, please refer to the table below for MonitorConfig.</para>
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
        /// <para>The output template of the monitoring session. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lp_ld</b>: low definition.</description></item>
        /// <item><description><b>lp_sd</b>: standard definition.</description></item>
        /// <item><description><b>lp_hd</b>: high definition.</description></item>
        /// <item><description><b>lp_ud</b>: ultra high definition.</description></item>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the output stream of the monitoring session. If you do not specify a name, the system generates a name at random.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monitorStream****</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
