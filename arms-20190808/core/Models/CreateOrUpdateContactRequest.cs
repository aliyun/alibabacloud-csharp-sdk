// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateContactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert contact.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, a new alert contact is created.</description></item>
        /// <item><description>If you specify this parameter, the specified alert contact is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JohnDoe</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The ID of the alert contact that is shown to the enterprise when the contact is mentioned with the at sign (@) by a third-party instant messaging (IM) tool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A123221</para>
        /// </summary>
        [NameInMap("CorpUserId")]
        [Validation(Required=false)]
        public string CorpUserId { get; set; }

        /// <summary>
        /// <para>The webhook URL of the DingTalk chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=69d4e0">https://oapi.dingtalk.com/robot/send?access_token=69d4e0</a>******</para>
        /// </summary>
        [NameInMap("DingRobotUrl")]
        [Validation(Required=false)]
        public string DingRobotUrl { get; set; }

        /// <summary>
        /// <para>The email address of the alert contact.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>Phone</b> and <b>Email</b> parameters. Each mobile number or email address can be used for only one alert contact.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Specifies whether the email address is verified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsEmailVerify")]
        [Validation(Required=false)]
        public bool? IsEmailVerify { get; set; }

        /// <summary>
        /// <para>The mobile number of the alert contact.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>Phone</b> and <b>Email</b> parameters. Each mobile number or email address can be used for only one alert contact.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1381111****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform if phone calls fail to be answered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No operation is performed.</description></item>
        /// <item><description>1: A phone call is made again.</description></item>
        /// <item><description>2: A text message is sent.</description></item>
        /// <item><description>3 (default value): The global default value is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReissueSendNotice")]
        [Validation(Required=false)]
        public long? ReissueSendNotice { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
