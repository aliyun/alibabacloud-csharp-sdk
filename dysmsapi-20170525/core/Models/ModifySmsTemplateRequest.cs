// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ModifySmsTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the message template. It is one of the reference information for template review. The description cannot exceed 100 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modify the parameters of the template.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The code of the message template.</para>
        /// <para>You can log on to the <a href="https://dysms.console.aliyun.com/dysms.htm">Short Message Service (SMS) console</a>, click <b>Go China</b> or <b>Go Globe</b> in the left-side navigation pane, and then view the template code on the <b>Templates</b> tab. You can also call the <a href="https://help.aliyun.com/document_detail/121208.html">AddSmsTemplate</a> operation to obtain the template code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_15255****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The content of the template. The content must be 1 to 500 characters in length.</para>
        /// <remarks>
        /// <para>When you modify a template, design the template content based on the review comments.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are applying for mobile registration. The verification code is: ${code}, valid for 5 minutes!</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The name of the template. The name must be 1 to 30 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun verification code</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: verification code</description></item>
        /// <item><description><b>1</b>: text message</description></item>
        /// <item><description><b>2</b>: promotional message</description></item>
        /// <item><description><b>3</b>: message sent to countries or regions outside the Chinese mainland</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
