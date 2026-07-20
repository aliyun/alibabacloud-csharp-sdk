// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy search. Matches the domain name or the corresponding resource ID.</para>
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
        /// <item><description><b>CPACK</b>: resource virtual order. Only orders generated from quotas are returned.</description></item>
        /// <item><description><b>BUY</b>: purchase order. Only orders generated from purchases are returned. You can ignore this type in most cases.</description></item>
        /// <item><description><b>UPLOAD</b>: uploaded certificate. Only uploaded certificates are returned.</description></item>
        /// <item><description><b>CERT</b>: certificate. Both issued certificates and uploaded certificates are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPACK</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2716559.html">ListResources</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******4wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paginated query. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The order status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PAYED</b>: Pending application. Valid when OrderType is set to CPACK or BUY.</description></item>
        /// <item><description><b>CHECKING</b>: Under review. Valid when OrderType is set to CPACK or BUY.</description></item>
        /// <item><description><b>CHECKED_FAIL</b>: Review failed. Valid when OrderType is set to CPACK or BUY.</description></item>
        /// <item><description><b>ISSUED</b>: Issued.</description></item>
        /// <item><description><b>WILLEXPIRED</b>: About to expire.</description></item>
        /// <item><description><b>EXPIRED</b>: Expired.</description></item>
        /// <item><description><b>NOTACTIVATED</b>: Not activated. Valid when OrderType is set to CPACK or BUY.</description></item>
        /// <item><description><b>REVOKED</b>: Revoked. Valid when OrderType is set to CPACK or BUY.</description></item>
        /// </list>
        /// <para>If OrderType is set to CERT or UPLOAD and Status is empty, valid certificates are returned by default, including issued and about-to-expire certificates. If OrderType is set to CPACK or BUY and Status is empty, all orders are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ISSUED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
