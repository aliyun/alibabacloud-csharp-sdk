// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class IsvGetAppIdRequest : TeaModel {
        /// <summary>
        /// 权限
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// The type of the application. Set the value to WHATSAPP.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
