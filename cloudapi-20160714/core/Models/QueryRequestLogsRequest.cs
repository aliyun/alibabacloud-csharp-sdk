// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class QueryRequestLogsRequest : TeaModel {
        /// <summary>
        /// The ID of the request log.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestLogId")]
        [Validation(Required=false)]
        public string RequestLogId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
