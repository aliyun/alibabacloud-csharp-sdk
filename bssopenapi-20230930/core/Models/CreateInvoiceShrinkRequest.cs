// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateInvoiceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the invoice amount. Two decimal places are supported.</para>
        /// <list type="bullet">
        /// <item><description>If left empty, the invoice is issued for the total invoiceable amount of all invoice candidate IDs.</description></item>
        /// <item><description>If specified, the invoice is issued for the specified amount. The specified amount cannot exceed the total invoiceable amount of all invoice candidate IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>The list of enterprises and accounts. If this parameter is left empty, the current account is queried.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public string EcIdAccountIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of invoice candidate IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InvoiceCandidateIds")]
        [Validation(Required=false)]
        public string InvoiceCandidateIdsShrink { get; set; }

        /// <summary>
        /// <para>The invoicing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Independent invoicing. The consumption of multiple accounts under an enterprise is invoiced independently for each account.</description></item>
        /// <item><description>1: Consolidated invoicing. The consumption of multiple accounts under an enterprise is consolidated and invoiced based on the invoicing entity.
        /// If only one account is specified in the AccountIds request parameter, independent invoicing is applied.</description></item>
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
        /// <para>The invoice remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remark information</para>
        /// </summary>
        [NameInMap("InvoiceRemark")]
        [Validation(Required=false)]
        public string InvoiceRemark { get; set; }

        /// <summary>
        /// <para>The invoice title ID.</para>
        /// <list type="bullet">
        /// <item><description>The ID returned by the ListInvoiceTitle operation for the current logon account.</description></item>
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
        /// <para>The invoice type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InvoiceType")]
        [Validation(Required=false)]
        public int? InvoiceType { get; set; }

        /// <summary>
        /// <para>The level-1 marketplace ID. If this parameter is left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The list of email addresses that receive the invoice. You can specify up to three email addresses.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecipientEmails")]
        [Validation(Required=false)]
        public string RecipientEmailsShrink { get; set; }

    }

}
