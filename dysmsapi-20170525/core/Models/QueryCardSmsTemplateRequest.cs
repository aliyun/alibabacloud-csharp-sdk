// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryCardSmsTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The code of the message template.</para>
        /// <para>You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_4139</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
