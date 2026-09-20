// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateRemindRequest : TeaModel {
        /// <summary>
        /// <para>The alert interval, in seconds. Minimum value: 1200. Default value: 1800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("AlertInterval")]
        [Validation(Required=false)]
        public int? AlertInterval { get; set; }

        /// <summary>
        /// <para>The alert notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAIL</description></item>
        /// <item><description>SMS</description></item>
        /// <item><description>PHONE. Only DataWorks Professional Edition and higher support phone alerts.</description></item>
        /// <item><description>DINGROBOTS (DingTalk chatbot). This method takes effect only after the RobotUrls parameter is configured.</description></item>
        /// <item><description>Webhooks (WeCom or Lark chatbot). This method takes effect only after the Webhooks parameter is configured.</description></item>
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
        /// <para>The configuration details for different alert recipients:</para>
        /// <list type="bullet">
        /// <item><description>When AlertUnit is set to OWNER (node owner), the configuration is left empty.</description></item>
        /// <item><description>When AlertUnit is set to OTHER (specified user), set this parameter to the Alibaba Cloud UIDs of the specified users. Separate multiple UIDs with commas (,). You can specify up to 10 users to receive alerts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9527952795279527</para>
        /// </summary>
        [NameInMap("AlertTargets")]
        [Validation(Required=false)]
        public string AlertTargets { get; set; }

        /// <summary>
        /// <para>The recipient of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OWNER: the node owner.</description></item>
        /// <item><description>OTHER: a specified user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OWNER</para>
        /// </summary>
        [NameInMap("AlertUnit")]
        [Validation(Required=false)]
        public string AlertUnit { get; set; }

        /// <summary>
        /// <para>The baseline IDs when the monitored object is a baseline. A rule can monitor up to 5 baselines. Separate multiple baseline IDs with commas (,).
        /// This parameter takes effect only when RemindUnit is set to BASELINE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BaselineIds")]
        [Validation(Required=false)]
        public string BaselineIds { get; set; }

        /// <summary>
        /// <para>The business process IDs when the monitored object is a business process. A rule can monitor up to 5 business processes. Separate multiple business process IDs with commas (,).
        /// This parameter takes effect only when RemindUnit is set to BIZPROCESS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BizProcessIds")]
        [Validation(Required=false)]
        public string BizProcessIds { get; set; }

        /// <summary>
        /// <para>The configuration details for different trigger conditions:</para>
        /// <list type="bullet">
        /// <item><description>When RemindType (trigger condition) is set to FINISHED, the configuration is left empty.</description></item>
        /// <item><description>When RemindType (trigger condition) is set to UNFINISHED, the configuration format is {&quot;hour&quot;:23,&quot;minu&quot;:59}. Valid values of hour: [0,47\]. Valid values of minu: [0,59\].</description></item>
        /// <item><description>When RemindType (trigger condition) is set to ERROR, the configuration is left empty.</description></item>
        /// <item><description>When RemindType (trigger condition) is set to CYCLE_UNFINISHED (cycle unfinished), the configuration format is {&quot;1&quot;:&quot;05:50&quot;,&quot;2&quot;:&quot;06:50&quot;,&quot;3&quot;:&quot;07:50&quot;,&quot;4&quot;:&quot;08:50&quot;,&quot;5&quot;:&quot;09:50&quot;,&quot;6&quot;:&quot;10:50&quot;,&quot;7&quot;:&quot;11:50&quot;,&quot;8&quot;:&quot;12:50&quot;,&quot;9&quot;:&quot;13:50&quot;,&quot;10&quot;:&quot;14:50&quot;,&quot;11&quot;:&quot;15:50&quot;,&quot;12&quot;:&quot;16:50&quot;,&quot;13&quot;:&quot;17:50&quot;,&quot;14&quot;:&quot;18:50&quot;,&quot;15&quot;:&quot;19:50&quot;,&quot;16&quot;:&quot;20:50&quot;,&quot;17&quot;:&quot;21:50&quot;,&quot;18&quot;:&quot;22:50&quot;,&quot;19&quot;:&quot;23:50&quot;,&quot;20&quot;:&quot;24:50&quot;,&quot;21&quot;:&quot;25:50&quot;}.
        /// The key in the JSON string is the cycle number. Valid values: [1,288\]. The value is the unfinished time for the corresponding cycle in the format hh:mm. Valid values of hh: [0,47\]. Valid values of mm: [0,59\].</description></item>
        /// <item><description>When RemindType (trigger condition) is set to TIMEOUT, the configuration format is 1800, in seconds. This means an alert is triggered if the instance has been running for more than 30 minutes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;hour&quot;:23,&quot;minu&quot;:59}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The end time of the do-not-disturb period. Alerts are not sent before this time. Format: hh:mm. Valid values of hh: [0,23\]. Valid values of mm: [0,59\].</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("DndEnd")]
        [Validation(Required=false)]
        public string DndEnd { get; set; }

        /// <summary>
        /// <para>The maximum number of alerts. Valid values: [1,10\]. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxAlertTimes")]
        [Validation(Required=false)]
        public int? MaxAlertTimes { get; set; }

        /// <summary>
        /// <para>The node IDs when the monitored object is a node. A rule can monitor up to 50 nodes. Separate multiple node IDs with commas (,).
        /// This parameter takes effect only when RemindUnit is set to NODE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The workspace ID when the monitored object is a workspace. A rule can monitor only one workspace.
        /// This parameter takes effect only when RemindUnit is set to PROJECT.</para>
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
        /// <item><description>FINISHED: The system monitors the instance from the start time and sends an alert when the node runs successfully.</description></item>
        /// <item><description>UNFINISHED: The system monitors the instance from the start time and sends an alert if the node has not finished running by the specified target time.</description></item>
        /// <item><description>ERROR: The system monitors the instance from the start time and sends an alert when the node encounters an error.</description></item>
        /// <item><description>CYCLE_UNFINISHED: The system sends an alert if the instance has not finished running within the specified cycle. This is typically used to monitor instances that run on an hourly cycle.</description></item>
        /// <item><description>TIMEOUT: The system monitors the instance from the start time and sends an alert if the node has not finished running after the specified duration. This is typically used to monitor the running duration of instances.</description></item>
        /// </list>
        /// <para>For more information about alert trigger conditions, see <a href="https://help.aliyun.com/document_detail/138172.html">Custom rules</a>.</para>
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
        /// <item><description>NODE</description></item>
        /// <item><description>BASELINE</description></item>
        /// <item><description>PROJECT (workspace)</description></item>
        /// <item><description>BIZPROCESS (business process)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NODE</para>
        /// </summary>
        [NameInMap("RemindUnit")]
        [Validation(Required=false)]
        public string RemindUnit { get; set; }

        /// <summary>
        /// <para>The webhook URLs of DingTalk group chatbots. Separate multiple webhook URLs with commas (,).
        /// When the parameter settings are set to undefined, the system clears the DingTalk chatbot webhook URLs.</para>
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
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFlag")]
        [Validation(Required=false)]
        public bool? UseFlag { get; set; }

        /// <summary>
        /// <para>The webhook URLs of WeCom or Lark chatbots. Separate multiple webhook URLs with commas (,). The alertMethods parameter must include the WEBHOOKS alerting method. When the parameter is set to undefined, the system clears the webhook URLs.</para>
        /// <para>Only DataWorks Enterprise Edition is supported.
        /// Active regions: China (Shanghai), China (Chengdu), China (Zhangjiakou), China (Beijing), China (Hangzhou), China (Shenzhen), Hong Kong (China), Germany (Frankfurt), Asia-Pacific Southeast 1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://open.feishu.cn/open-apis/bot/v2/hook/">https://open.feishu.cn/open-apis/bot/v2/hook/</a>*******</para>
        /// </summary>
        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public string Webhooks { get; set; }

    }

}
