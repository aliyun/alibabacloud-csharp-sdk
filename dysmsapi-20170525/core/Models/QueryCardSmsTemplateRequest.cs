// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryCardSmsTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The code of the card SMS template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>After you call the <a href="~~CreateCardSmsTemplate~~">CreateCardSmsTemplate</a> operation, the value of the <b>TemplateCode</b> response parameter is the code of the newly created card SMS template.</para>
        /// </description></item>
        /// <item><description><para>You can also log on to the <a href="https://dysms.console.aliyun.com/domestic/card">Domestic Card SMS</a> page in the console and view the card SMS template code on the <b>Template Management</b> tab.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_2****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
