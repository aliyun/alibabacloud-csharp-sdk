// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class AddSmsTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the message template. It is one of the reference information for template review. The description cannot exceed 100 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apply for a template to send verification codes.</para>
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
        /// <para>The content of the template. The content can be up to 500 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/108253.html">Message template specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are applying for mobile registration. The verification code is: ${code}, valid for 5 minutes!</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The name of the template. The name can be up to 30 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun Test</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: verification code</description></item>
        /// <item><description><b>1</b>: notification</description></item>
        /// <item><description><b>2</b>: promotional message</description></item>
        /// <item><description><b>3</b>: message sent to countries or regions outside the Chinese mainland</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only enterprise users can send promotional messages, or send messages to countries or regions outside the Chinese mainland.</para>
        /// </remarks>
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
