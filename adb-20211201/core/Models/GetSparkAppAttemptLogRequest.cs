// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppAttemptLogRequest : TeaModel {
        /// <summary>
        /// The ID of the log.
        /// 
        /// > You can call the [ListSparkAppAttempts](https://help.aliyun.com/document_detail/455887.html) operation to query the information about the retry attempts of a Spark application, including the retry log IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AttemptId")]
        [Validation(Required=false)]
        public string AttemptId { get; set; }

        /// <summary>
        /// The number of log entries to return. Valid values: 1 to 500. Default value: 300.
        /// </summary>
        [NameInMap("LogLength")]
        [Validation(Required=false)]
        public long? LogLength { get; set; }

        /// <summary>
        /// The log offset.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
