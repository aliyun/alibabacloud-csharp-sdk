// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePrinterEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The user events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribePrinterEventsResponseBodyEvents> Events { get; set; }
        public class DescribePrinterEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-8fupvkhg0aayu****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The cloud computer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desktop-001</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The end user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5651188b-3070-d1cc-5311-75753d59****</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The printer driver name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HP LaserJet PCL 6</para>
            /// </summary>
            [NameInMap("PrinterDriver")]
            [Validation(Required=false)]
            public string PrinterDriver { get; set; }

            /// <summary>
            /// <para>The number of copies to print.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PrinterJobCopies")]
            [Validation(Required=false)]
            public int? PrinterJobCopies { get; set; }

            /// <summary>
            /// <para>The print job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>report.pdf</para>
            /// </summary>
            [NameInMap("PrinterJobName")]
            [Validation(Required=false)]
            public string PrinterJobName { get; set; }

            /// <summary>
            /// <para>The total number of pages in the print job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PrinterJobPages")]
            [Validation(Required=false)]
            public int? PrinterJobPages { get; set; }

            /// <summary>
            /// <para>The number of printed pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PrinterJobPrintedPages")]
            [Validation(Required=false)]
            public int? PrinterJobPrintedPages { get; set; }

            /// <summary>
            /// <para>The print job size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2632446</para>
            /// </summary>
            [NameInMap("PrinterJobSize")]
            [Validation(Required=false)]
            public long? PrinterJobSize { get; set; }

            /// <summary>
            /// <para>The print job time, in millisecond-precision UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706140800000</para>
            /// </summary>
            [NameInMap("PrinterJobTime")]
            [Validation(Required=false)]
            public long? PrinterJobTime { get; set; }

            /// <summary>
            /// <para>The printer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HP LaserJet Pro</para>
            /// </summary>
            [NameInMap("PrinterName")]
            [Validation(Required=false)]
            public string PrinterName { get; set; }

            /// <summary>
            /// <para>The printer port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USB001</para>
            /// </summary>
            [NameInMap("PrinterPort")]
            [Validation(Required=false)]
            public string PrinterPort { get; set; }

            /// <summary>
            /// <para>The printer redirection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PrinterRedirType")]
            [Validation(Required=false)]
            public int? PrinterRedirType { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E54EB497-D7B7-5F04-B744-D8DFA7B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
