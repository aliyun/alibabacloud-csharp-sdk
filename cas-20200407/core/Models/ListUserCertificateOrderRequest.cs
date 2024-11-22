// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The domain name that is bound or the ID of the resource. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-instanceId</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The type of the order. Default value: <b>CPACK</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CPACK</b>: virtual resource order. If you set OrderType to CPACK, only the information about orders that are generated to consume the certificate quota is returned.</description></item>
        /// <item><description><b>BUY</b>: purchase order. If you set OrderType to BUY, only the information about purchase orders is returned. In most cases, this type of order can be ignored.</description></item>
        /// <item><description><b>UPLOAD</b>: uploaded certificate. If you set OrderType to UPLOAD, only uploaded certificates are returned.</description></item>
        /// <item><description><b>CERT</b>: certificate. If you set OrderType to CERT, both issued certificates and uploaded certificates are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPACK</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can call the <a href="https://help.aliyun.com/document_detail/2716559.html">ListResources</a> operation to obtain the ID.</para>
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
        /// <para>The certificate status of the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PAYED</b>: pending application. You can set Status to PAYED only if you set OrderType to CPACK or BUY.</description></item>
        /// <item><description><b>CHECKING</b>: validating. You can set Status to CHECKING only if you set OrderType to CPACK or BUY.</description></item>
        /// <item><description><b>CHECKED_FAIL</b>: validation failed. You can set Status to CHECKED_FAIL only if you set OrderType to CPACK or BUY.</description></item>
        /// <item><description><b>ISSUED</b>: issued.</description></item>
        /// <item><description><b>WILLEXPIRED</b>: about to expire.</description></item>
        /// <item><description><b>EXPIRED</b>: expired.</description></item>
        /// <item><description><b>NOTACTIVATED</b>: not activated. You can set Status to NOTACTIVATED only if you set OrderType to CPACK or BUY.</description></item>
        /// <item><description><b>REVOKED</b>: revoked. You can set Status to REVOKED only if you set OrderType to CPACK or BUY.</description></item>
        /// </list>
        /// <para>If you set OrderType to CERT or UPLOAD and Status is left empty, valid certificates are returned by default, including issued certificates and certificates that are about to expire. If you set OrderType to CPACK or BUY and Status is left empty, all orders are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ISSUED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
