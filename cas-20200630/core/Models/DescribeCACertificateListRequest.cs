// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCACertificateListRequest : TeaModel {
        /// <summary>
        /// <para>The current status of the CA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>issue: enabled.</description></item>
        /// <item><description>forbidden: disabled.</description></item>
        /// <item><description>revoke: revoked.</description></item>
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
        /// <item><description>root: root CA.</description></item>
        /// <item><description>subRoot: subordinate CA.</description></item>
        /// <item><description>externalCa: externally imported CA.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>subRoot</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. Settings: specify the desired page number. Default value: <b>1</b>.</para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/328095.html">DescribeCACertificateList</a> to query the unique identifiers of all CA certificates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1ee47e24-c51b-67cc-aa6b-1f7561cf9d9a</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The issuing authority of the CA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>local: private certificate.</description></item>
        /// <item><description>iTrusChina: compliance CA.</description></item>
        /// <item><description>external: externally imported.</description></item>
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
        /// <para>The number of CA certificates per page in a paging query. Settings: specify the desired number of entries per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The time-based validity status of the CA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>valid: The CA is within its validity period.</description></item>
        /// <item><description>notValid: The CA has expired.</description></item>
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
