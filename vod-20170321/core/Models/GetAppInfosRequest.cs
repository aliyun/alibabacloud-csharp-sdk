// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppInfosRequest : TeaModel {
        /// <summary>
        /// The IDs of applications. You can obtain application IDs from the response to the [CreateAppInfo](~~113266~~) or [ListAppInfo](~~114000~~) operation.
        /// 
        /// *   You can specify a maximum of 10 application IDs.
        /// *   Separate application IDs with commas (,).
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

    }

}
