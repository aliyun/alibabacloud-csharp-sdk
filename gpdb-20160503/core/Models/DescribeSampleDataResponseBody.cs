// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSampleDataResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The error message returned if an error occurs. This message does not affect the execution of the operation.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Indicates whether a sample dataset is loaded to the instance. Valid values:
        /// 
        /// *   **true**: A sample dataset is loaded.
        /// *   **false**: No sample dataset is loaded.
        /// </summary>
        [NameInMap("HasSampleData")]
        [Validation(Required=false)]
        public bool? HasSampleData { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SampleDataStatus")]
        [Validation(Required=false)]
        public string SampleDataStatus { get; set; }

    }

}
