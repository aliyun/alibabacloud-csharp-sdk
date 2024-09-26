// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateRemindRequest : TeaModel {
        /// <summary>
        /// <para>The intervals at which alert notifications are sent. Unit: seconds. Minimum value: 1200. Default value: 1800.</para>
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
        /// <item><description>SMS: Alert notifications are sent by text message.</description></item>
        /// <item><description>PHONE: Alert notifications are sent by phone call. You can use this notification method only in DataWorks Professional Edition or more advanced editions.</description></item>
        /// <item><description>DINGROBOTS: Alert notifications are sent by DingTalk message. You can use this notification method only if the RobotUrls parameter is configured.</description></item>
        /// <item><description>WEBHOOKS (WeCom or Lark chatbot): Alert notifications are sent by WeCom or Lark message. You can use this notification method only if the Webhooks parameter is configured.</description></item>
        /// </list>
        /// <para>Multiple notification methods are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS,MAIL</para>
        /// </summary>
        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        /// <summary>
        /// <para>The value format required by this parameter varies based on the value that you specify for the AlertUnit parameter. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If the AlertUnit parameter is set to OWNER, leave this parameter empty.</description></item>
        /// <item><description>If the AlertUnit parameter is set to OTHER, set this parameter to the unique ID (UID) of the specified user. You can specify multiple UIDs. Separate them with commas (,). A maximum of 10 UIDs can be specified for receiving alert notifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9527952795279527</para>
        /// </summary>
        [NameInMap("AlertTargets")]
        [Validation(Required=false)]
        public string AlertTargets { get; set; }

        /// <summary>
        /// <para>The recipient to whom alert notifications are sent. Valid values: OWNER and OTHER. The value OWNER indicates that alert notifications are sent to the object owner. The value OTHER indicates that alert notifications are sent to a specified user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OWNER</para>
        /// </summary>
        [NameInMap("AlertUnit")]
        [Validation(Required=false)]
        public string AlertUnit { get; set; }

        /// <summary>
        /// <para>The ID of the baseline to which the custom alert rule is applied. A maximum of 5 baselines can be specified for a custom alert rule. You can specify multiple IDs. Separate multiple IDs with commas (,). This parameter takes effect when you set the RemindUnit parameter to BASELINE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BaselineIds")]
        [Validation(Required=false)]
        public string BaselineIds { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to which the custom alert rule is applied. A maximum of 5 workflows can be specified for a custom alert rule. You can specify multiple IDs. Separate multiple IDs with commas (,). This parameter takes effect when you set the RemindUnit parameter to BIZPROCESS.</para>
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
        /// <item><description>If the RemindType parameter is set to UNFINISHED, set this parameter to key-value pairs. Example: {&quot;hour&quot;:23,&quot;minu&quot;:59}. Valid values of hour: [0,47]. Valid values of minu: [0,59].</description></item>
        /// <item><description>If the RemindType parameter is set to ERROR, leave this parameter empty.</description></item>
        /// <item><description>If the RemindType parameter is set to CYCLE_UNFINISHED, set this parameter to key-value pairs in the JSON format. Example: {&quot;1&quot;:&quot;05:50&quot;,&quot;2&quot;:&quot;06:50&quot;,&quot;3&quot;:&quot;07:50&quot;,&quot;4&quot;:&quot;08:50&quot;,&quot;5&quot;:&quot;09:50&quot;,&quot;6&quot;:&quot;10:50&quot;,&quot;7&quot;:&quot;11:50&quot;,&quot;8&quot;:&quot;12:50&quot;,&quot;9&quot;:&quot;13:50&quot;,&quot;10&quot;:&quot;14:50&quot;,&quot;11&quot;:&quot;15:50&quot;,&quot;12&quot;:&quot;16:50&quot;,&quot;13&quot;:&quot;17:50&quot;,&quot;14&quot;:&quot;18:50&quot;,&quot;15&quot;:&quot;19:50&quot;,&quot;16&quot;:&quot;20:50&quot;,&quot;17&quot;:&quot;21:50&quot;,&quot;18&quot;:&quot;22:50&quot;,&quot;19&quot;:&quot;23:50&quot;,&quot;20&quot;:&quot;24:50&quot;,&quot;21&quot;:&quot;25:50&quot;}. A key in the JSON string indicates the sequence number of a cycle. Valid values of keys: 1 to 288. A value in the JSON string indicates the time in point when a monitored instance times out in the relevant cycle. Values must be in the format of hh:mm. Valid values of hh: [0,47]. Valid values of mm: [0,59].</description></item>
        /// <item><description>If the RemindType parameter is set to TIMEOUT, set this parameter to the timeout period. Unit: seconds. Example: 1800. This indicates that an alert notification is sent if the running duration of a monitored instance exceeds 30 minutes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;hour&quot;:23,&quot;minu&quot;:59}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The end of the period during which no alert notifications are sent. Specify the time in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].</para>
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
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxAlertTimes")]
        [Validation(Required=false)]
        public int? MaxAlertTimes { get; set; }

        /// <summary>
        /// <para>The ID of the node to which the custom alert rule is applied. A maximum of 50 nodes can be specified for a custom alert rule. You can specify multiple IDs. Separate multiple IDs with commas (,). This parameter takes effect when you set the RemindUnit parameter to NODE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the custom alert rule is applied. You can specify only one workspace for a custom alert rule. This parameter takes effect when you set the RemindUnit parameter to PROJECT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The custom alert rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

        /// <summary>
        /// <para>The name of the custom alert rule. The name cannot exceed 128 characters in length.</para>
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
        /// <item><description>FINISHED: The system monitors an instance when it starts to run and sends an alert notification after the running of the instance is complete.</description></item>
        /// <item><description>UNFINISHED: The system monitors an instance when it starts to run and sends an alert notification if the instance is still running at the specified point in time.</description></item>
        /// <item><description>ERROR: The system monitors an instance when it starts to run and sends an alert notification if an error occurs.</description></item>
        /// <item><description>CYCLE_UNFINISHED: The system sends an alert notification if a monitored instance is still running at the end of the specified cycle. In most cases, you can configure this trigger condition for node instances that are scheduled to run by hour.</description></item>
        /// <item><description>TIMEOUT: The system monitors an instance when it starts to run and sends an alert notification if the instance is still running after the specified period ends. In most cases, you can configure this trigger condition to monitor the running duration of node instances.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/138172.html">Manage custom alert rules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("RemindType")]
        [Validation(Required=false)]
        public string RemindType { get; set; }

        /// <summary>
        /// <para>The type of the object to which the custom alert rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NODE</description></item>
        /// <item><description>BASELINE</description></item>
        /// <item><description>PROJECT</description></item>
        /// <item><description>BIZPROCESS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NODE</para>
        /// </summary>
        [NameInMap("RemindUnit")]
        [Validation(Required=false)]
        public string RemindUnit { get; set; }

        /// <summary>
        /// <para>The webhook URL of the DingTalk chatbot. You can specify multiple webhook URLs. Separate multiple webhook URLs with commas (,). If this parameter is set to undefined, the specified webhook URLs are cleared.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFlag")]
        [Validation(Required=false)]
        public bool? UseFlag { get; set; }

        /// <summary>
        /// <para>The webhook URL of the WeCom or Lark chatbot. You can specify multiple webhook URLs. Separate multiple webhook URLs with commas (,). The value of AlertMethods must include WEBHOOKS. If this parameter is set to undefined, the specified webhook URLs are cleared.</para>
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
