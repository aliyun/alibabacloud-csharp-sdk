// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeUserLangRequest : TeaModel {
        /// <summary>
        /// The new language. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("UserLang")]
        [Validation(Required=false)]
        public string UserLang { get; set; }

    }

}
