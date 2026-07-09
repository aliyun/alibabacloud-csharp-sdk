// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateInvoiceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the invoice amount. Supports up to two decimal places.</para>
        /// <list type="bullet">
        /// <item><description>If not specified, the invoice will be issued for the total invoiceable amount of all invoiceCandidateIds.</description></item>
        /// <item><description>If specified, the invoice will be issued for the specified amount. The specified amount cannot exceed the total invoiceable amount of all invoiceCandidateIds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>Enterprise and account list. If empty, the current account is queried.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public string EcIdAccountIdsShrink { get; set; }

        /// <summary>
        /// <para>List of invoice candidate IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InvoiceCandidateIds")]
        [Validation(Required=false)]
        public string InvoiceCandidateIdsShrink { get; set; }

        /// <summary>
        /// <para>Invoice mode.</para>
        /// <list type="bullet">
        /// <item><description>0: Independent invoicing. Expenses of multiple accounts under the enterprise are invoiced separately for each account.</description></item>
        /// <item><description>1: Consolidated invoicing. Expenses of multiple accounts under the enterprise are consolidated and invoiced under the invoicing entity.
        /// If only one account is passed in the AccountIds parameter, independent invoicing is applied.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InvoiceMode")]
        [Validation(Required=false)]
        public int? InvoiceMode { get; set; }

        /// <summary>
        /// <para>Invoice remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注信息</para>
        /// </summary>
        [NameInMap("InvoiceRemark")]
        [Validation(Required=false)]
        public string InvoiceRemark { get; set; }

        /// <summary>
        /// <para>Invoice title ID.</para>
        /// <list type="bullet">
        /// <item><description>The ID parameter returned by the ListInvoiceTitle API for the current logged-in account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("InvoiceTitleId")]
        [Validation(Required=false)]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// <para>Invoice type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InvoiceType")]
        [Validation(Required=false)]
        public int? InvoiceType { get; set; }

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
        /// <para>List of email addresses to receive the invoice. A maximum of 3 can be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecipientEmails")]
        [Validation(Required=false)]
        public string RecipientEmailsShrink { get; set; }

    }

}
