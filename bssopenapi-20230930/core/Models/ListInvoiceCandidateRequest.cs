// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListInvoiceCandidateRequest : TeaModel {
        [NameInMap("BillingCycles")]
        [Validation(Required=false)]
        public List<int?> BillingCycles { get; set; }

        [NameInMap("BusinessIds")]
        [Validation(Required=false)]
        public List<string> BusinessIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<ListInvoiceCandidateRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class ListInvoiceCandidateRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("InvoiceIssuers")]
        [Validation(Required=false)]
        public List<string> InvoiceIssuers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-06-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<int?> Status { get; set; }

        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<int?> Types { get; set; }

    }

}
