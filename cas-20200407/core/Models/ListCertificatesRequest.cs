// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertificatesRequest : TeaModel {
        /// <summary>
        /// <para>The source of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: a formal certificate.</description></item>
        /// <item><description>TEST: a test certificate.</description></item>
        /// <item><description>UPLOAD: an uploaded certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("CertificateSource")]
        [Validation(Required=false)]
        public string CertificateSource { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>issued</b>: Issued.</description></item>
        /// <item><description><b>revoked</b>: Revoked.</description></item>
        /// <item><description><b>willExpire</b>: About to expire.</description></item>
        /// <item><description><b>expired</b>: Expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// <para>The page number of the current page.</para>
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
        /// <para>The keyword for fuzzy match. The keyword is matched against domain names, names, and corresponding resource IDs.</para>
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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
