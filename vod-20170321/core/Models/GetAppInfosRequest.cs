// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppInfosRequest : TeaModel {
        /// <summary>
        /// The IDs of applications. You can obtain application IDs from the response to the [CreateAppInfo](https://help.aliyun.com/document_detail/113266.html) or [ListAppInfo](https://help.aliyun.com/document_detail/114000.html) operation.
        /// 
        /// *   You can specify a maximum of 10 application IDs.
        /// *   Separate application IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

    }

}
