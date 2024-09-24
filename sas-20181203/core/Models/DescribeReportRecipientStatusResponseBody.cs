// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeReportRecipientStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The report recipients.</para>
        /// </summary>
        [NameInMap("ReportRecipientList")]
        [Validation(Required=false)]
        public List<DescribeReportRecipientStatusResponseBodyReportRecipientList> ReportRecipientList { get; set; }
        public class DescribeReportRecipientStatusResponseBodyReportRecipientList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the email address is verified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>1: yes</description></item>
            /// </list>
            /// <remarks>
            /// <para> If no email is specified when you create a report, the value of this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsVerify")]
            [Validation(Required=false)]
            public int? IsVerify { get; set; }

            /// <summary>
            /// <para>The email address of the report recipient.</para>
            /// <remarks>
            /// <para> If no email is specified when you create a report, the value of this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Recipient")]
            [Validation(Required=false)]
            public string Recipient { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53C0DC1F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
