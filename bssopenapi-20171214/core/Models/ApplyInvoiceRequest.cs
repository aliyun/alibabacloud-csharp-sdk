// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ApplyInvoiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the address to which the invoice is delivered. This parameter is required if the invoice is a paper invoice. Set the ID to the value of the AddressId parameter returned by calling the QueryCustomerAddressList operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>237958367</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public long? AddressId { get; set; }

        /// <summary>
        /// <para>The nickname of the applicant. The system does not verify the nickname.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ApplyUserNick")]
        [Validation(Required=false)]
        public string ApplyUserNick { get; set; }

        /// <summary>
        /// <para>The ID of the customer. Set the ID to the value of the CustomerId parameter returned by calling the QueryInvoicingCustomerList operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>124132423</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public long? CustomerId { get; set; }

        /// <summary>
        /// <para>The amount of the invoice. Unit: Cent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>124132</para>
        /// </summary>
        [NameInMap("InvoiceAmount")]
        [Validation(Required=false)]
        public long? InvoiceAmount { get; set; }

        /// <summary>
        /// <para>Specifies whether to invoice by amount. A value of true indicates that the user applies for the invoice based on the InvoiceAmount parameter. A value of false indicates that the user applies for the invoice based on the total amount of the invoicing items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InvoiceByAmount")]
        [Validation(Required=false)]
        public bool? InvoiceByAmount { get; set; }

        /// <summary>
        /// <para>The type of the invoice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: paper invoice</description></item>
        /// <item><description>1: electronic invoice</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InvoicingType")]
        [Validation(Required=false)]
        public int? InvoicingType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The channel that is used to process the invoice. A value of 0 indicates that the invoice is processed by Alibaba Cloud. A value of 1 indicates that the invoice is processed by the tax platform. Set the value to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessWay")]
        [Validation(Required=false)]
        public int? ProcessWay { get; set; }

        /// <summary>
        /// <para>The IDs of the selected invoicing items. Set the IDs to the IDs returned by calling the QueryEvaluateList operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>384752367</para>
        /// </summary>
        [NameInMap("SelectedIds")]
        [Validation(Required=false)]
        public List<long?> SelectedIds { get; set; }

        /// <summary>
        /// <para>The remarks made by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserRemark")]
        [Validation(Required=false)]
        public string UserRemark { get; set; }

        [NameInMap("emails")]
        [Validation(Required=false)]
        public string Emails { get; set; }

    }

}
