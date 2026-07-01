// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class DeleteSmsTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The SMS template code. You can delete SMS templates that are recalled, rejected, or approved. You cannot delete SMS templates that are being reviewed.</para>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> operation to obtain the SMS template code.</para>
        /// </description></item>
        /// <item><description><para>You can also obtain the SMS template code on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page of the Short Message Service (SMS) console.</para>
        /// <remarks>
        /// <para>Notice: Deleted SMS templates cannot be recovered and cannot be used to send messages. Proceed with caution..</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_152550****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
