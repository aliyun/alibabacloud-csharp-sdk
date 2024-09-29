// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateAlertContactRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JohnDoe</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The webhook URL of the DingTalk chatbot. For more information about how to obtain the URL, see <a href="https://www.alibabacloud.com/help/zh/doc-detail/106247.htm">Configure a DingTalk chatbot to send alert notifications</a>. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.</para>
        /// <remarks>
        /// <para> Enter <c>alert</c> in the custom keyword field of DingTalk chatbot security settings.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=91f2f6">https://oapi.dingtalk.com/robot/send?access_token=91f2f6</a>****</para>
        /// </summary>
        [NameInMap("DingRobotWebhookUrl")]
        [Validation(Required=false)]
        public string DingRobotWebhookUrl { get; set; }

        /// <summary>
        /// <para>The email address of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The mobile number of the alert contact. You must specify at least one of the following parameters: PhoneNum, Email, and DingRobotWebhookUrl.</para>
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
        /// <para>The ID of the resource group. You can obtain the resource group ID in the <b>Resource Management</b> console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2eq4peca****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
