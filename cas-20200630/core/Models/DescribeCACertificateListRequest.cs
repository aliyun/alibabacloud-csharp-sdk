// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCACertificateListRequest : TeaModel {
        /// <summary>
        /// <para>The status of the CA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>issue: enabled.</para>
        /// </description></item>
        /// <item><description><para>forbidden: disabled.</para>
        /// </description></item>
        /// <item><description><para>revoke: revoked.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>issue</para>
        /// </summary>
        [NameInMap("CaStatus")]
        [Validation(Required=false)]
        public string CaStatus { get; set; }

        /// <summary>
        /// <para>The type of the CA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>root: root CA.</para>
        /// </description></item>
        /// <item><description><para>subRoot: intermediate CA.</para>
        /// </description></item>
        /// <item><description><para>externalCa: an imported external CA.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>subRoot</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

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
        /// <para>The unique identifier of the CA certificate.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/328095.html">DescribeCACertificateList</a> to query the unique identifiers of all CA certificates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1ee47e24-c51b-67cc-aa6b-1f7561cf9d9a</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The issuer of the CA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>local: private certificate.</para>
        /// </description></item>
        /// <item><description><para>iTrusChina: a trusted CA.</para>
        /// </description></item>
        /// <item><description><para>external: an imported external CA.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("IssuerType")]
        [Validation(Required=false)]
        public string IssuerType { get; set; }

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
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The validity status of the CA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>valid: The CA certificate is valid.</para>
        /// </description></item>
        /// <item><description><para>notValid: The CA certificate has expired.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("ValidStatus")]
        [Validation(Required=false)]
        public string ValidStatus { get; set; }

    }

}
