// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeCollectionResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The number of vector dimensions.
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// The fields that are used for full-text search. Multiple fields are separated by commas (,).
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The metadata of vector data, which is a JSON string in the MAP format. The key specifies the field name, and the value specifies the data type.
        /// 
        /// **
        /// 
        /// **Warning** Reserved fields such as id, vector, and to_tsvector cannot be used.
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The distance metrics.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The analyzer that is used for full-text search.
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **success**
        /// *   **fail**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
