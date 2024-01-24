// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstDbSlsInfoResponseBody : TeaModel {
        /// <summary>
        /// The details of the SQL audit.
        /// </summary>
        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public DescribeInstDbSlsInfoResponseBodyAuditInfo AuditInfo { get; set; }
        public class DescribeInstDbSlsInfoResponseBodyAuditInfo : TeaModel {
            /// <summary>
            /// The name of the LogStore.
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// The name of the Log Service project.
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
