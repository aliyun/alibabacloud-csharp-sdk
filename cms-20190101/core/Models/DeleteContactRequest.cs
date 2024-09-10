// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteContactRequest : TeaModel {
        /// <summary>
        /// The name of the alert contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

    }

}
