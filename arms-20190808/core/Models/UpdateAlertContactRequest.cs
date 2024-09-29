// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateAlertContactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert contact to be updated. You can call the SearchAlertContact operation to query the contact ID. For more information, see <a href="https://help.aliyun.com/document_detail/130703.html">SearchAlertContact</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The new name of the alert contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John Doe</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The new webhook URL of the DingTalk chatbot. For more information, see <a href="https://help.aliyun.com/document_detail/106247.html">Configure a DingTalk chatbot to send alert notifications</a>. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the original parameter value is deleted. If you specify this parameter, the original parameter value is updated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=91f2f6">https://oapi.dingtalk.com/robot/send?access_token=91f2f6</a>****</para>
        /// </summary>
        [NameInMap("DingRobotWebhookUrl")]
        [Validation(Required=false)]
        public string DingRobotWebhookUrl { get; set; }

        /// <summary>
        /// <para>The new email address of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the original parameter value is deleted. If you specify this parameter, the original parameter value is updated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The new mobile phone number of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the original parameter value is deleted. If you specify this parameter, the original parameter value is updated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1381111****</para>
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        /// <summary>
        /// <para>The ID of the region. Set the value to <c>cn-hangzhou</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert contact receives system notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The alert contact receives system notifications.</description></item>
        /// <item><description><c>false</c>: The alert contact does not receive system notifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SystemNoc")]
        [Validation(Required=false)]
        public bool? SystemNoc { get; set; }

    }

}
