// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ResetAppCodeRequest : TeaModel {
        /// <summary>
        /// The AppCode of the app.
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// The new AppCode of the app.
        /// </summary>
        [NameInMap("NewAppCode")]
        [Validation(Required=false)]
        public string NewAppCode { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
