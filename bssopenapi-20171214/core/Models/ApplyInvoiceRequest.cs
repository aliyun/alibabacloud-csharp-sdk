// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ApplyInvoiceRequest : TeaModel {
        /// <summary>
        /// The ID of the address to which the invoice is delivered. This parameter is required if the invoice is a paper invoice. Set the ID to the value of the AddressId parameter returned by calling the QueryCustomerAddressList operation.
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public long? AddressId { get; set; }

        /// <summary>
        /// The nickname of the applicant. The system does not verify the nickname.
        /// </summary>
        [NameInMap("ApplyUserNick")]
        [Validation(Required=false)]
        public string ApplyUserNick { get; set; }

        /// <summary>
        /// The ID of the customer. Set the ID to the value of the CustomerId parameter returned by calling the QueryInvoicingCustomerList operation.
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public long? CustomerId { get; set; }

        /// <summary>
        /// The amount of the invoice. Unit: Cent.
        /// </summary>
        [NameInMap("InvoiceAmount")]
        [Validation(Required=false)]
        public long? InvoiceAmount { get; set; }

        /// <summary>
        /// Specifies whether to invoice by amount. A value of true indicates that the user applies for the invoice based on the InvoiceAmount parameter. A value of false indicates that the user applies for the invoice based on the total amount of the invoicing items.
        /// </summary>
        [NameInMap("InvoiceByAmount")]
        [Validation(Required=false)]
        public bool? InvoiceByAmount { get; set; }

        /// <summary>
        /// The type of the invoice. Valid values:
        /// 
        /// *   0: paper invoice
        /// *   1: electronic invoice
        /// </summary>
        [NameInMap("InvoicingType")]
        [Validation(Required=false)]
        public int? InvoicingType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The channel that is used to process the invoice. A value of 0 indicates that the invoice is processed by Alibaba Cloud. A value of 1 indicates that the invoice is processed by the tax platform. Set the value to 1.
        /// </summary>
        [NameInMap("ProcessWay")]
        [Validation(Required=false)]
        public int? ProcessWay { get; set; }

        /// <summary>
        /// The IDs of the selected invoicing items. Set the IDs to the IDs returned by calling the QueryEvaluateList operation.
        /// </summary>
        [NameInMap("SelectedIds")]
        [Validation(Required=false)]
        public List<long?> SelectedIds { get; set; }

        /// <summary>
        /// The remarks made by the user.
        /// </summary>
        [NameInMap("UserRemark")]
        [Validation(Required=false)]
        public string UserRemark { get; set; }

    }

}
