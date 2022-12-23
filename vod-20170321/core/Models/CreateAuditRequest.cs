// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAuditRequest : TeaModel {
        /// <summary>
        /// The array of the review content.
        /// 
        /// You can specify a maximum of **20** videos to be reviewed. The array must be converted into a string as the value of this parameter.
        /// 
        /// For more information about the parameters in AuditContent, see the **AuditContent** section of this topic.
        /// </summary>
        [NameInMap("AuditContent")]
        [Validation(Required=false)]
        public string AuditContent { get; set; }

    }

}
