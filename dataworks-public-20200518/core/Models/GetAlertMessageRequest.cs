// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetAlertMessageRequest : TeaModel {
        /// <summary>
        /// The alert ID. You can all the [ListAlertMessages](https://help.aliyun.com/document_detail/173961.html) operation to obtain the alert ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public string AlertId { get; set; }

    }

}
