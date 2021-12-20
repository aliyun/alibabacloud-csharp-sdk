// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class GetConnectionPoolIpOperationResultResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// OssPath
        /// </summary>
        [NameInMap("ResultFilePaths")]
        [Validation(Required=false)]
        public List<string> ResultFilePaths { get; set; }

    }

}
