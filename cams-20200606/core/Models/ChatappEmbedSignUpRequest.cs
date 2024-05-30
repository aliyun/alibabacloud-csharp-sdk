// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ChatappEmbedSignUpRequest : TeaModel {
        /// <summary>
        /// The InputToken returned after the embedded signup flow is complete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputToken")]
        [Validation(Required=false)]
        public string InputToken { get; set; }

    }

}
