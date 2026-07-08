// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertificatesRequest : TeaModel {
        /// <summary>
        /// <para>The source of the certificate.</para>
        /// <list type="bullet">
        /// <item><description><para>BUY: A purchased certificate.</para>
        /// </description></item>
        /// <item><description><para>TEST: A test certificate.</para>
        /// </description></item>
        /// <item><description><para>UPLOAD: An uploaded certificate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("CertificateSource")]
        [Validation(Required=false)]
        public string CertificateSource { get; set; }

        /// <summary>
        /// <para>The status of the certificate.</para>
        /// <list type="bullet">
        /// <item><description><para><b>issued</b>: The certificate is issued.</para>
        /// </description></item>
        /// <item><description><para><b>revoked</b>: The certificate is revoked.</para>
        /// </description></item>
        /// <item><description><para><b>willExpire</b>: The certificate is about to expire.</para>
        /// </description></item>
        /// <item><description><para><b>expired</b>: The certificate has expired.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-ivauto-hqito6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A keyword for a fuzzy query. The keyword can be a domain name, a certificate name, or a resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
