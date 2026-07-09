// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListInvoiceCandidateRequest : TeaModel {
        /// <summary>
        /// <para>List of billing cycles.</para>
        /// </summary>
        [NameInMap("BillingCycles")]
        [Validation(Required=false)]
        public List<int?> BillingCycles { get; set; }

        /// <summary>
        /// <para>List of business document numbers.</para>
        /// </summary>
        [NameInMap("BusinessIds")]
        [Validation(Required=false)]
        public List<string> BusinessIds { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>List of enterprises and accounts. If empty, the current account itself is queried.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<ListInvoiceCandidateRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class ListInvoiceCandidateRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>List of accounts to access. If empty, all accounts under the current entity ID are selected.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>Enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>The end time. Format: yyyy-mm-dd hh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>List of invoice issuers.</para>
        /// </summary>
        [NameInMap("InvoiceIssuers")]
        [Validation(Required=false)]
        public List<string> InvoiceIssuers { get; set; }

        /// <summary>
        /// <para>Primary marketplace ID. If empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time. Format: yyyy-mm-dd hh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>List of invoice candidate statuses.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<int?> Status { get; set; }

        /// <summary>
        /// <para>List of invoice candidate types.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<int?> Types { get; set; }

    }

}
