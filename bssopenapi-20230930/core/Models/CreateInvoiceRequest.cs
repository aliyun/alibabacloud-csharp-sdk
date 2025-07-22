// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateInvoiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<CreateInvoiceRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class CreateInvoiceRequestEcIdAccountIds : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InvoiceCandidateIds")]
        [Validation(Required=false)]
        public List<string> InvoiceCandidateIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InvoiceMode")]
        [Validation(Required=false)]
        public int? InvoiceMode { get; set; }

        [NameInMap("InvoiceRemark")]
        [Validation(Required=false)]
        public string InvoiceRemark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("InvoiceTitleId")]
        [Validation(Required=false)]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InvoiceType")]
        [Validation(Required=false)]
        public int? InvoiceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecipientEmails")]
        [Validation(Required=false)]
        public List<string> RecipientEmails { get; set; }

    }

}
