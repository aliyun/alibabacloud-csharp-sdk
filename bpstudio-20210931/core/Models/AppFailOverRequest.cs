// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class AppFailOverRequest : TeaModel {
        /// <summary>
        /// The application ID.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The destination zone to which you want to switch the disaster recovery application.
        /// </summary>
        [NameInMap("FailZone")]
        [Validation(Required=false)]
        public string FailZone { get; set; }

    }

}
