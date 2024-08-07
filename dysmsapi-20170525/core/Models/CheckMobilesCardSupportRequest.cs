// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CheckMobilesCardSupportRequest : TeaModel {
        /// <summary>
        /// The list of mobile phone numbers that receive messages.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mobiles")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Mobiles { get; set; }

        /// <summary>
        /// The code of the message template. You can view the template code in the **Template Code** column on the **Templates** tab of the **Go China** page in the Alibaba Cloud SMS console.
        /// 
        /// > Make sure that the message template has been approved.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
