// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateCardSmsTemplateRequest : TeaModel {
        /// <summary>
        /// The mobile phone manufacturer. Valid values:
        /// 
        /// *   **HuaWei**: HUAWEI
        /// *   **XiaoMi**: Xiaomi
        /// *   **OPPO**: OPPO
        /// *   **VIVO**: vivo
        /// *   **MEIZU**: MEIZU
        /// 
        /// > If this parameter is not specified, the system automatically specifies a supported mobile phone manufacturer.
        /// </summary>
        [NameInMap("Factorys")]
        [Validation(Required=false)]
        public string Factorys { get; set; }

        /// <summary>
        /// The description of the message template.
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// The content of the card message template.
        /// 
        /// > 
        /// 
        /// *   For information about fields such as Template, ExtendInfo, TemplateContent, TmpCard, and Action, see [Parameters of card message templates](https://help.aliyun.com/document_detail/434929.html).
        /// 
        /// *   Message template content varies based on the template type. For more information, see [Sample message templates](https://help.aliyun.com/document_detail/435361.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public Dictionary<string, object> Template { get; set; }

        /// <summary>
        /// The name of the card message template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
