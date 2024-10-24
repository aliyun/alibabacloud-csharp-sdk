// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTemplateRequest : TeaModel {
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
        /// <para>The code of the message template.</para>
        /// <para>You can log on to the <a href="https://dysms.console.aliyun.com/dysms.htm">Short Message Service (SMS) console</a>, click <b>Go China</b> or <b>Go Globe</b> in the left-side navigation pane, and then view the template code on the <b>Templates</b> tab. You can also call the <a href="https://help.aliyun.com/document_detail/121208.html">AddSmsTemplate</a> operation to obtain the template code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_1525***</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
