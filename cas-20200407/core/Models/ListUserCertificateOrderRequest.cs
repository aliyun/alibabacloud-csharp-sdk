// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>Performs a fuzzy query. The keyword can be a domain name or a resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-instanceId</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The resource type. Default value: <b>CPACK</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CPACK</b>: An order for a resource plan. Only orders created from a resource plan are returned.</para>
        /// </description></item>
        /// <item><description><para><b>BUY</b>: A direct purchase. Only orders created from direct purchases are returned. You can ignore this type in most cases.</para>
        /// </description></item>
        /// <item><description><para><b>UPLOAD</b>: An uploaded certificate. Only uploaded certificates are returned.</para>
        /// </description></item>
        /// <item><description><para><b>CERT</b>: A certificate. Both issued and uploaded certificates are returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPACK</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information, see <a href="https://help.aliyun.com/document_detail/2716559.html">ListResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******4wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The status of the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PAYED</b>: The certificate is pending application. This value is valid only when OrderType is set to CPACK or BUY.</para>
        /// </description></item>
        /// <item><description><para><b>CHECKING</b>: The certificate is under review. This value is valid only when OrderType is set to CPACK or BUY.</para>
        /// </description></item>
        /// <item><description><para><b>CHECKED_FAIL</b>: The review failed. This value is valid only when OrderType is set to CPACK or BUY.</para>
        /// </description></item>
        /// <item><description><para><b>ISSUED</b>: The certificate is issued.</para>
        /// </description></item>
        /// <item><description><para><b>WILLEXPIRED</b>: The certificate is about to expire.</para>
        /// </description></item>
        /// <item><description><para><b>EXPIRED</b>: The certificate has expired.</para>
        /// </description></item>
        /// <item><description><para><b>NOTACTIVATED</b>: The certificate is not activated. This value is valid only when OrderType is set to CPACK or BUY.</para>
        /// </description></item>
        /// <item><description><para><b>REVOKED</b>: The certificate is revoked. This value is valid only when OrderType is set to CPACK or BUY.</para>
        /// </description></item>
        /// </list>
        /// <para>If OrderType is CERT or UPLOAD and you leave this parameter empty, active certificates are returned by default. Active certificates are those in the ISSUED or WILLEXPIRED state. If OrderType is CPACK or BUY and you leave this parameter empty, all orders are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ISSUED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
