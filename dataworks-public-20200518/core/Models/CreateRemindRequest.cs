// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateRemindRequest : TeaModel {
        /// <summary>
        /// <para>The minimum alert interval, in seconds. Minimum value: 1200. Default value: 1800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("AlertInterval")]
        [Validation(Required=false)]
        public int? AlertInterval { get; set; }

        /// <summary>
        /// <para>The alert method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAIL: email.</description></item>
        /// <item><description>SMS: text message.
        /// &lt;props=&quot;intl&quot;&gt;The regions that support SMS alerts are Singapore, Malaysia (Kuala Lumpur), and Germany (Frankfurt).
        /// &lt;props=&quot;china&quot;&gt;- PHONE: phone call. Only DataWorks Professional Edition and higher editions are supported.</description></item>
        /// <item><description>Webhooks (WeCom or Lark chatbot). This alert method takes effect only after the Webhooks parameter is configured.</description></item>
        /// <item><description>DINGROBOTS: DingTalk chatbot.</description></item>
        /// </list>
        /// <para>Separate multiple alert methods with commas (,).</para>
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
        /// <item><description><para>When AlertUnit (alert recipient) is set to OWNER (node owner), pass an empty value.</para>
        /// </description></item>
        /// <item><description><para>When AlertUnit (alert recipient) is set to OTHER (specified user), pass the Alibaba Cloud UIDs of the specified users. Separate multiple Alibaba Cloud UIDs with commas (,). A maximum of 10 UIDs are supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9527952795279527</para>
        /// </summary>
        [NameInMap("AlertTargets")]
        [Validation(Required=false)]
        public string AlertTargets { get; set; }

        /// <summary>
        /// <para>The granularity of the alert recipient. Valid values: OWNER (node owner) and OTHER (specified user).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OWNER</para>
        /// </summary>
        [NameInMap("AlertUnit")]
        [Validation(Required=false)]
        public string AlertUnit { get; set; }

        /// <summary>
        /// <para>The IDs of the baselines to monitor when RemindUnit (object type) is set to BASELINE (baseline). Separate multiple IDs with commas (,). A maximum of 5 baselines can be monitored by a single rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BaselineIds")]
        [Validation(Required=false)]
        public string BaselineIds { get; set; }

        /// <summary>
        /// <para>The IDs of the business processes to monitor when RemindUnit (object type) is set to BIZPROCESS (business process). Separate multiple business process IDs with commas (,). A maximum of 5 business processes can be monitored by a single rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("BizProcessIds")]
        [Validation(Required=false)]
        public string BizProcessIds { get; set; }

        /// <summary>
        /// <para>The descriptions for different trigger conditions are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>When RemindType (trigger condition) is set to FINISHED (completed), pass an empty value.</para>
        /// </description></item>
        /// <item><description><para>When RemindType (trigger condition) is set to UNFINISHED (not completed), pass parameter in the format of {&quot;hour&quot;:23,&quot;minu&quot;:59}. Valid values of hour: [0,47\]. Valid values of minu: [0,59\].</para>
        /// </description></item>
        /// <item><description><para>When RemindType (trigger condition) is set to ERROR (error), pass an empty value.</para>
        /// </description></item>
        /// <item><description><para>When RemindType (trigger condition) is set to CYCLE_UNFINISHED (cycle not completed), pass parameter in the format of {&quot;1&quot;:&quot;05:50&quot;,&quot;2&quot;:&quot;06:50&quot;,&quot;3&quot;:&quot;07:50&quot;,&quot;4&quot;:&quot;08:50&quot;,&quot;5&quot;:&quot;09:50&quot;,&quot;6&quot;:&quot;10:50&quot;,&quot;7&quot;:&quot;11:50&quot;,&quot;8&quot;:&quot;12:50&quot;,&quot;9&quot;:&quot;13:50&quot;,&quot;10&quot;:&quot;14:50&quot;,&quot;11&quot;:&quot;15:50&quot;,&quot;12&quot;:&quot;16:50&quot;,&quot;13&quot;:&quot;17:50&quot;,&quot;14&quot;:&quot;18:50&quot;,&quot;15&quot;:&quot;19:50&quot;,&quot;16&quot;:&quot;20:50&quot;,&quot;17&quot;:&quot;21:50&quot;,&quot;18&quot;:&quot;22:50&quot;,&quot;19&quot;:&quot;23:50&quot;,&quot;20&quot;:&quot;24:50&quot;,&quot;21&quot;:&quot;25:50&quot;}. The key in the JSON character string is the cycle number. Valid values: [1,288\]. The value is the not-completed time for the corresponding cycle, in the hh:mm format. Valid values of hh: [0,47\]. Valid values of mm: [0,59\].</para>
        /// </description></item>
        /// <item><description><para>When RemindType (trigger condition) is set to TIMEOUT (running timeout), pass parameter as a value such as 1800, in seconds. This means that an alert is triggered if the running time exceeds 30 minutes from the start of execution.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;hour&quot;:&quot;23&quot;,&quot;minu&quot;:&quot;59&quot;}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The end time of the do-not-disturb period, in the hh:mm format. Valid values of hh: [0,23\]. Valid values of mm: [0,59\].</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("DndEnd")]
        [Validation(Required=false)]
        public string DndEnd { get; set; }

        /// <summary>
        /// <para>The maximum number of alerts. Minimum value: 1. Maximum value: 10. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxAlertTimes")]
        [Validation(Required=false)]
        public int? MaxAlertTimes { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes to monitor when RemindUnit (object type) is set to NODE (node). Separate multiple IDs with commas (,). A maximum of 50 nodes can be monitored by a single rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to monitor when RemindUnit (object type) is set to PROJECT (workspace). A single rule can monitor only one workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9527</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the custom rule. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_error_remind</para>
        /// </summary>
        [NameInMap("RemindName")]
        [Validation(Required=false)]
        public string RemindName { get; set; }

        /// <summary>
        /// <para>The trigger condition. Valid values: FINISHED (completed), UNFINISHED (not completed), ERROR (error), CYCLE_UNFINISHED (cycle not completed), and TIMEOUT (running timeout).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("RemindType")]
        [Validation(Required=false)]
        public string RemindType { get; set; }

        /// <summary>
        /// <para>The type of the object. Valid values: NODE (node), BASELINE (baseline), PROJECT (workspace), and BIZPROCESS (business process).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NODE</para>
        /// </summary>
        [NameInMap("RemindUnit")]
        [Validation(Required=false)]
        public string RemindUnit { get; set; }

        /// <summary>
        /// <para>The webhook URLs of DingTalk chatbots. Separate multiple webhook URLs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=">https://oapi.dingtalk.com/robot/send?access_token=</a>******************************</para>
        /// </summary>
        [NameInMap("RobotUrls")]
        [Validation(Required=false)]
        public string RobotUrls { get; set; }

        /// <summary>
        /// <para>The webhook URLs of WeCom or Lark chatbots. Separate multiple webhook URLs with commas (,). The alertMethods parameter must include the WEBHOOKS alert method.</para>
        /// <para>Only DataWorks Enterprise Edition is supported.
        /// Available regions: China (Shanghai), China (Chengdu), China (Zhangjiakou), China (Beijing), China (Hangzhou), China (Shenzhen), Hong Kong (China), Germany (Frankfurt), and Singapore.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://open.feishu.cn/open-apis/bot/v2/hook/">https://open.feishu.cn/open-apis/bot/v2/hook/</a>*******</para>
        /// </summary>
        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public string Webhooks { get; set; }

    }

}
