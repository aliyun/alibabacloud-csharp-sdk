// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListTracesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("messageKey")]
        [Validation(Required=false)]
        public string MessageKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
