// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateRemindRequest : TeaModel {
        /// <summary>
        /// <para>The alert interval. Unit: seconds. Minimum value: 1200. Default value: 1800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("AlertInterval")]
        [Validation(Required=false)]
        public int? AlertInterval { get; set; }

        /// <summary>
        /// <para>The alert methods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAIL: email.</description></item>
        /// <item><description>SMS: text message.</description></item>
        /// <item><description>PHONE: phone call. This method is supported only in DataWorks Professional Edition or a higher edition.</description></item>
        /// <item><description>DINGROBOTS: DingTalk chatbot. This method takes effect only after the RobotUrls parameter is configured.</description></item>
        /// <item><description>Webhooks: WeCom or Lark chatbot. This method takes effect only after the Webhooks parameter is configured.</description></item>
        /// </list>
        /// <para>Separate multiple alert methods with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS,MAIL</para>
        /// </summary>
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        /// <summary>
        /// <para>The parameter settings for different alert recipients:</para>
        /// <list type="bullet">
        /// <item><description>If AlertUnit is set to OWNER (node task owner), leave this parameter empty.</description></item>
        /// <item><description>If AlertUnit is set to OTHER (specified users), specify their Alibaba Cloud UIDs. Separate multiple UIDs with commas (,). You can specify up to 10 users to receive alerts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9527952795279527</para>
        /// </summary>
        [NameInMap("AlertTargets")]
        [Validation(Required=false)]
        public string AlertTargets { get; set; }

        /// <summary>
        /// <para>The recipients of the alert. Valid values: OWNER (task owner) and OTHER (specified users).</para>
        /// 
        /// <b>Example:</b>
        /// <para>OWNER</para>
        /// </summary>
        [NameInMap("AlertUnit")]
        [Validation(Required=false)]
        public string AlertUnit { get; set; }

        /// <summary>
        /// <para>The baseline IDs when the monitored object is a baseline. A single monitoring rule can monitor up to 5 baselines. Separate multiple baseline IDs with commas (,).
        /// This parameter takes effect only when the RemindUnit parameter is set to BASELINE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BaselineIds")]
        [Validation(Required=false)]
        public string BaselineIds { get; set; }

        /// <summary>
        /// <para>The workflow IDs when the monitored object is a workflow. A single monitoring rule can monitor up to 5 workflows. Separate multiple workflow IDs with commas (,).
        /// This parameter takes effect only when the RemindUnit parameter is set to BIZPROCESS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BizProcessIds")]
        [Validation(Required=false)]
        public string BizProcessIds { get; set; }

        /// <summary>
        /// <para>The parameter settings for different trigger conditions:</para>
        /// <list type="bullet">
        /// <item><description>If the RemindType (trigger condition) is set to FINISHED, leave the parameter settings empty.</description></item>
        /// <item><description>If the RemindType (trigger condition) is set to UNFINISHED, specify the parameter settings in the {&quot;hour&quot;:23,&quot;minu&quot;:59} format. Valid values for hour: [0,47]. Valid values for minu: [0,59].</description></item>
        /// <item><description>If the RemindType (trigger condition) is set to ERROR, leave the parameter settings empty.</description></item>
        /// <item><description>If the RemindType (trigger condition) is set to CYCLE_UNFINISHED (unfinished cycle), specify the parameter settings in the {&quot;1&quot;:&quot;05:50&quot;,&quot;2&quot;:&quot;06:50&quot;,&quot;3&quot;:&quot;07:50&quot;,&quot;4&quot;:&quot;08:50&quot;,&quot;5&quot;:&quot;09:50&quot;,&quot;6&quot;:&quot;10:50&quot;,&quot;7&quot;:&quot;11:50&quot;,&quot;8&quot;:&quot;12:50&quot;,&quot;9&quot;:&quot;13:50&quot;,&quot;10&quot;:&quot;14:50&quot;,&quot;11&quot;:&quot;15:50&quot;,&quot;12&quot;:&quot;16:50&quot;,&quot;13&quot;:&quot;17:50&quot;,&quot;14&quot;:&quot;18:50&quot;,&quot;15&quot;:&quot;19:50&quot;,&quot;16&quot;:&quot;20:50&quot;,&quot;17&quot;:&quot;21:50&quot;,&quot;18&quot;:&quot;22:50&quot;,&quot;19&quot;:&quot;23:50&quot;,&quot;20&quot;:&quot;24:50&quot;,&quot;21&quot;:&quot;25:50&quot;} format. The key in the JSON string is the cycle number, and the valid values are [1,288]. The value is the unfinished time for the cycle, in the hh:mm format. Valid values for hh: [0,47]. Valid values for mm: [0,59].</description></item>
        /// <item><description>If the RemindType (trigger condition) is set to TIMEOUT, specify the parameter settings in seconds. Example: 1800. This means that an alert is triggered if the instance runs for more than 30 minutes after it starts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;hour&quot;:23,&quot;minu&quot;:59}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The end time of the do-not-disturb period, before which no alerts are sent. Specify the time in the hh:mm format. Valid values for hh: [0,23]. Valid values for mm: [0,59].</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("DndEnd")]
        [Validation(Required=false)]
        public string DndEnd { get; set; }

        /// <summary>
        /// <para>The maximum number of alerts. Valid values: [1,10]. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxAlertTimes")]
        [Validation(Required=false)]
        public int? MaxAlertTimes { get; set; }

        /// <summary>
        /// <para>The node IDs when the monitored object is a node. A single monitoring rule can monitor up to 50 nodes. Separate multiple node IDs with commas (,).
        /// This parameter takes effect only when the RemindUnit parameter is set to NODE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The workspace ID when the monitored object is a workspace. A single monitoring rule can monitor only one workspace.
        /// This parameter takes effect only when the RemindUnit parameter is set to PROJECT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The ID of the custom rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

        /// <summary>
        /// <para>The name of the custom rule. The name cannot exceed 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update_remindname</para>
        /// </summary>
        [NameInMap("RemindName")]
        [Validation(Required=false)]
        public string RemindName { get; set; }

        /// <summary>
        /// <para>The condition that triggers the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FINISHED: The system sends an alert when the task runs successfully. The monitoring starts from the time when the instance starts to run.</description></item>
        /// <item><description>UNFINISHED: The system sends an alert if the task is still running at the specified time. The monitoring starts from the time when the instance starts to run.</description></item>
        /// <item><description>ERROR: The system sends an alert when an error occurs during the running of the task. The monitoring starts from the time when the instance starts to run.</description></item>
        /// <item><description>CYCLE_UNFINISHED: The system sends an alert if the instance is still running within the specified cycle. This value is typically used to monitor instances that run on an hourly cycle.</description></item>
        /// <item><description>TIMEOUT: The system sends an alert if the task is still running after the specified running duration. The monitoring starts from the time when the instance starts to run. This value is typically used to monitor the running duration of instances.</description></item>
        /// </list>
        /// <para>For more information about the conditions that trigger alert rules, see <a href="https://help.aliyun.com/document_detail/138172.html">Custom rules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("RemindType")]
        [Validation(Required=false)]
        public string RemindType { get; set; }

        /// <summary>
        /// <para>The type of the monitored object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NODE: node</description></item>
        /// <item><description>BASELINE: baseline</description></item>
        /// <item><description>PROJECT: workspace</description></item>
        /// <item><description>BIZPROCESS: workflow</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NODE</para>
        /// </summary>
        [NameInMap("RemindUnit")]
        [Validation(Required=false)]
        public string RemindUnit { get; set; }

        /// <summary>
        /// <para>The webhook URLs of the DingTalk group chatbot. Separate multiple webhook URLs with commas (,).
        /// If the parameter settings are set to undefined, the system clears the webhook URLs of the DingTalk chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=">https://oapi.dingtalk.com/robot/send?access_token=</a>******************************</para>
        /// </summary>
        [NameInMap("RobotUrls")]
        [Validation(Required=false)]
        public string RobotUrls { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The alert rule is enabled.</description></item>
        /// <item><description>false: The alert rule is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFlag")]
        [Validation(Required=false)]
        public bool? UseFlag { get; set; }

        /// <summary>
        /// <para>The webhook URLs of the WeCom or Lark chatbot. Separate multiple webhook URLs with commas (,). The AlertMethods parameter must include the WEBHOOKS alerting method. If the parameter settings are set to undefined, the system clears the webhook URLs.</para>
        /// <para>This parameter is supported only in DataWorks Enterprise Edition.
        /// Available regions: China (Shanghai), China (Chengdu), China (Zhangjiakou), China (Beijing), China (Hangzhou), China (Shenzhen), China (Hong Kong), Germany (Frankfurt), and Singapore.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://open.feishu.cn/open-apis/bot/v2/hook/">https://open.feishu.cn/open-apis/bot/v2/hook/</a>*******</para>
        /// </summary>
        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public string Webhooks { get; set; }

    }

}
