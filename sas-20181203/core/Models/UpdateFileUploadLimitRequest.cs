// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileUploadLimitRequest : TeaModel {
        /// <summary>
        /// The QPS limit on the files uploaded from the client. Valid values: 100 to 10000.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

    }

}
