// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeReportRecipientStatusResponseBody : TeaModel {
        /// <summary>
        /// The report recipients.
        /// </summary>
        [NameInMap("ReportRecipientList")]
        [Validation(Required=false)]
        public List<DescribeReportRecipientStatusResponseBodyReportRecipientList> ReportRecipientList { get; set; }
        public class DescribeReportRecipientStatusResponseBodyReportRecipientList : TeaModel {
            /// <summary>
            /// Indicates whether the email address is verified. Valid values:
            /// 
            /// *   0: no
            /// *   1: yes
            /// 
            /// >  If no email is specified when you create a report, the value of this parameter is empty.
            /// </summary>
            [NameInMap("IsVerify")]
            [Validation(Required=false)]
            public int? IsVerify { get; set; }

            /// <summary>
            /// The email address of the report recipient.
            /// 
            /// >  If no email is specified when you create a report, the value of this parameter is empty.
            /// </summary>
            [NameInMap("Recipient")]
            [Validation(Required=false)]
            public string Recipient { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
