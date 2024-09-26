// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateRemindRequest : TeaModel {
        /// <summary>
        /// <para>The minimum interval at which alerts are reported. Unit: seconds. Minimum value: 1200. Default value: 1800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("AlertInterval")]
        [Validation(Required=false)]
        public int? AlertInterval { get; set; }

        /// <summary>
        /// <para>The notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAIL: Alert notifications are sent by email.</description></item>
        /// <item><description>SMS: Alert notifications are sent by text message. Alert notifications can be sent by text message only in the Singapore, Malaysia (Kuala Lumpur), and Germany (Frankfurt) regions.</description></item>
        /// <item><description>WEBHOOKS (WeCom or Lark chatbot): Alert notifications are sent by WeCom or Lark message. If you want to use this notification method, you must configure the Webhooks parameter.</description></item>
        /// </list>
        /// <para>You can specify multiple notification methods. Separate them with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS,MAIL</para>
        /// </summary>
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the AlertUnit parameter is set to OWNER, leave this parameter empty.</description></item>
        /// <item><description>If the AlertUnit parameter is set to OTHER, set this parameter to the ID of the Alibaba Cloud account used by the specified user. You can specify multiple IDs. Separate multiple IDs with commas (,). You can specify a maximum of 10 IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9527952795279527</para>
        /// </summary>
        [NameInMap("AlertTargets")]
        [Validation(Required=false)]
        public string AlertTargets { get; set; }

        /// <summary>
        /// <para>The recipient of the alert. Valid values: OWNER and OTHER. The value OWNER indicates the node owner. The value OTHER indicates a specified user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OWNER</para>
        /// </summary>
        [NameInMap("AlertUnit")]
        [Validation(Required=false)]
        public string AlertUnit { get; set; }

        /// <summary>
        /// <para>The ID of the baseline to which the custom alert rule is applied. This parameter takes effect when the RemindUnit parameter is set to BASELINE. You can specify multiple IDs. Separate multiple IDs with commas (,). A maximum of five baselines can be specified for a custom alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BaselineIds")]
        [Validation(Required=false)]
        public string BaselineIds { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to which the custom alert rule is applied. This parameter takes effect when the RemindUnit parameter is set to BIZPROCESS. You can specify multiple IDs. Separate multiple IDs with commas (,). A maximum of five workflows can be specified for a custom alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BizProcessIds")]
        [Validation(Required=false)]
        public string BizProcessIds { get; set; }

        /// <summary>
        /// <para>The details of the conditions that trigger an alert.</para>
        /// <list type="bullet">
        /// <item><description>If the RemindType parameter is set to FINISHED, leave this parameter empty.</description></item>
        /// <item><description>If the RemindType parameter is set to UNFINISHED, configure this parameter as key-value pairs. Example: {&quot;hour&quot;:23,&quot;minu&quot;:59}. Valid values of hour: [0,47]. Valid values of minu: [0,59].</description></item>
        /// <item><description>If the RemindType parameter is set to ERROR, leave this parameter empty.</description></item>
        /// <item><description>If the RemindType parameter is set to CYCLE_UNFINISHED, configure this parameter as key-value pairs. Example: {&quot;1&quot;:&quot;05:50&quot;,&quot;2&quot;:&quot;06:50&quot;,&quot;3&quot;:&quot;07:50&quot;,&quot;4&quot;:&quot;08:50&quot;,&quot;5&quot;:&quot;09:50&quot;,&quot;6&quot;:&quot;10:50&quot;,&quot;7&quot;:&quot;11:50&quot;,&quot;8&quot;:&quot;12:50&quot;,&quot;9&quot;:&quot;13:50&quot;,&quot;10&quot;:&quot;14:50&quot;,&quot;11&quot;:&quot;15:50&quot;,&quot;12&quot;:&quot;16:50&quot;,&quot;13&quot;:&quot;17:50&quot;,&quot;14&quot;:&quot;18:50&quot;,&quot;15&quot;:&quot;19:50&quot;,&quot;16&quot;:&quot;20:50&quot;,&quot;17&quot;:&quot;21:50&quot;,&quot;18&quot;:&quot;22:50&quot;,&quot;19&quot;:&quot;23:50&quot;,&quot;20&quot;:&quot;24:50&quot;,&quot;21&quot;:&quot;25:50&quot;}. The key indicates the ID of the cycle. Valid values: [1,288]. The value indicates the timeout period of the node that is running in the cycle. Specify the value in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</description></item>
        /// <item><description>If the RemindType parameter is set to TIMEOUT, set this parameter to the timeout period. Unit: seconds. Example: 1800. This value indicates that an alert is reported if the node has run for more than 30 minutes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;hour&quot;:23,&quot;minu&quot;:59}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The end time of the quiet hours. Specify the time in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("DndEnd")]
        [Validation(Required=false)]
        public string DndEnd { get; set; }

        /// <summary>
        /// <para>The maximum number of alerts. Valid values: 1 to 10. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxAlertTimes")]
        [Validation(Required=false)]
        public int? MaxAlertTimes { get; set; }

        /// <summary>
        /// <para>The ID of the node to which the custom alert rule is applied. This parameter takes effect when the RemindUnit parameter is set to NODE. You can specify multiple IDs. Separate multiple IDs with commas (,). A maximum of 50 nodes can be specified for a custom alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the custom alert rule is applied. This parameter takes effect when the RemindUnit parameter is set to PROJECT. You can specify only one workspace for a custom alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9527</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the custom alert rule. The name cannot exceed 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_error_remind</para>
        /// </summary>
        [NameInMap("RemindName")]
        [Validation(Required=false)]
        public string RemindName { get; set; }

        /// <summary>
        /// <para>The conditions that trigger an alert. Valid values: FINISHED, UNFINISHED, ERROR, CYCLE_UNFINISHED, and TIMEOUT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("RemindType")]
        [Validation(Required=false)]
        public string RemindType { get; set; }

        /// <summary>
        /// <para>The type of the object to which the custom alert rule is applied. Valid values: NODE, BASELINE, PROJECT, and BIZPROCESS. The value NODE indicates a node. The value BASELINE indicates a baseline. The value PROJECT indicates a workspace. The value BIZPROCESS indicates a workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NODE</para>
        /// </summary>
        [NameInMap("RemindUnit")]
        [Validation(Required=false)]
        public string RemindUnit { get; set; }

        /// <summary>
        /// <para>The webhook URL of the DingTalk chatbot. You can specify multiple webhook URLs. Separate multiple webhook URLs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=">https://oapi.dingtalk.com/robot/send?access_token=</a>******************************</para>
        /// </summary>
        [NameInMap("RobotUrls")]
        [Validation(Required=false)]
        public string RobotUrls { get; set; }

        /// <summary>
        /// <para>The webhook URL of the WeCom or Lark chatbot. You can specify multiple webhook URLs. Separate multiple webhook URLs with commas (,). You must specify WEBHOOKS for AlertMethods.</para>
        /// <para>Only DataWorks Enterprise Edition supports this parameter. The webhook URL-based alerting feature is supported in the following regions: China (Shanghai), China (Chengdu), China (Zhangjiakou), China (Beijing), China (Hangzhou), China (Shenzhen), China (Hong Kong), Germany (Frankfurt), and Singapore.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://open.feishu.cn/open-apis/bot/v2/hook/">https://open.feishu.cn/open-apis/bot/v2/hook/</a>*******</para>
        /// </summary>
        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public string Webhooks { get; set; }

    }

}
