// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppInfosRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can specify a maximum of 10 application IDs. Separate them with commas (,).
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

    }

}
