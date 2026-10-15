// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ApplyInvoiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the mailing address, which corresponds to the ID parameter returned by the QueryCustomerAddressList operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>237958367</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public long? AddressId { get; set; }

        /// <summary>
        /// <para>The nickname of the applicant. The system does not verify this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ApplyUserNick")]
        [Validation(Required=false)]
        public string ApplyUserNick { get; set; }

        /// <summary>
        /// <para>The ID of the invoice title information, which corresponds to the ID parameter returned by the QueryInvoicingCustomerList operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>124132423</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public long? CustomerId { get; set; }

        /// <summary>
        /// <para>The requested invoice amount, in cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("InvoiceAmount")]
        [Validation(Required=false)]
        public long? InvoiceAmount { get; set; }

        /// <summary>
        /// <para>Specifies whether to issue the invoice based on a specified amount. If this parameter is set to true, the invoice is applied for based on the specified InvoiceAmount. Otherwise, the invoice is applied for based on the total amount of the selected objects to be invoiced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InvoiceByAmount")]
        [Validation(Required=false)]
        public bool? InvoiceByAmount { get; set; }

        /// <summary>
        /// <para>The invoice type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: VAT special invoice.</description></item>
        /// <item><description>1: VAT general invoice.</description></item>
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
        /// <para>The invoicing channel. Set this parameter to 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Processed by Alibaba Cloud.</description></item>
        /// <item><description>1: Processed by the tax platform.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessWay")]
        [Validation(Required=false)]
        public int? ProcessWay { get; set; }

        /// <summary>
        /// <para>The list of IDs of the selected objects to be invoiced, which correspond to the ID parameters returned by the QueryEvaluateList operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>384752367</para>
        /// </summary>
        [NameInMap("SelectedIds")]
        [Validation(Required=false)]
        public List<long?> SelectedIds { get; set; }

        /// <summary>
        /// <para>The user remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserRemark")]
        [Validation(Required=false)]
        public string UserRemark { get; set; }

        /// <summary>
        /// <para>The email addresses for receiving the invoice. The maximum length of this field is 200 characters. Separate multiple email addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:aaa@aa.com">aaa@aa.com</a>,<a href="mailto:bbb@bb.com">bbb@bb.com</a></para>
        /// </summary>
        [NameInMap("emails")]
        [Validation(Required=false)]
        public string Emails { get; set; }

    }

}
