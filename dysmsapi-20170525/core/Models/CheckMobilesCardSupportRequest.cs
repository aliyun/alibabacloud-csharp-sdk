// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CheckMobilesCardSupportRequest : TeaModel {
        /// <summary>
        /// <para>The list of phone numbers to be queried.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mobiles")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Mobiles { get; set; }

        /// <summary>
        /// <para>The code of the card SMS template.
        /// Log on to the SMS Service console and go to the <a href="https://dysms.console.aliyun.com/domestic/card">Domestic Card SMS</a> page. On the <b>Template Management</b> tab, you can view the list of card SMS templates.</para>
        /// <remarks>
        /// <para>The template must be added and approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
