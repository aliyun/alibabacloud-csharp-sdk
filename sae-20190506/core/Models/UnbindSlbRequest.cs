// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UnbindSlbRequest : TeaModel {
        /// <summary>
        /// true
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [NameInMap("Internet")]
        [Validation(Required=false)]
        public bool? Internet { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

    }

}
