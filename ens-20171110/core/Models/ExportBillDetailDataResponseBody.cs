// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportBillDetailDataResponseBody : TeaModel {
        /// <summary>
        /// The download path of the exported file.
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
