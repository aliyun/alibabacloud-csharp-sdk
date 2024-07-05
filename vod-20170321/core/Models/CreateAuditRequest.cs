// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAuditRequest : TeaModel {
        /// <summary>
        /// The review content. You can specify up to **100** audio or video files in a request. The value must be converted to a string.\\
        /// For more information about this parameter, see the **AuditContent** section of this topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuditContent")]
        [Validation(Required=false)]
        public string AuditContent { get; set; }

    }

}
