// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeUserDcdnStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the DCDN service is activated.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates whether your account has overdue payments.
        /// </summary>
        [NameInMap("InDebt")]
        [Validation(Required=false)]
        public bool? InDebt { get; set; }

        /// <summary>
        /// Indicates whether the grace period for your overdue payments expired.
        /// </summary>
        [NameInMap("InDebtOverdue")]
        [Validation(Required=false)]
        public bool? InDebtOverdue { get; set; }

        /// <summary>
        /// Indicates whether the service is available.
        /// </summary>
        [NameInMap("OnService")]
        [Validation(Required=false)]
        public bool? OnService { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
