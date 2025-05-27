// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryMobilesCardSupportRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The list of mobile phone numbers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mobiles")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Mobiles { get; set; }

        /// <summary>
        /// <para>The code of the message template. You can view the template code in the <b>Template Code</b> column on the <b>Templates</b> tab of the <b>Go China</b> page in the Alibaba Cloud SMS console.</para>
        /// <remarks>
        /// <para>Make sure that the message template has been approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_SMS_0000</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
