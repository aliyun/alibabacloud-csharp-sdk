// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ResetAppSecretRequest : TeaModel {
        /// <summary>
        /// The key of the application that is used to make an API call.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("NewAppKey")]
        [Validation(Required=false)]
        public string NewAppKey { get; set; }

        /// <summary>
        /// The new key of the application. To improve compatibility, we recommend that you use other parameters.
        /// </summary>
        [NameInMap("NewAppSecret")]
        [Validation(Required=false)]
        public string NewAppSecret { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
