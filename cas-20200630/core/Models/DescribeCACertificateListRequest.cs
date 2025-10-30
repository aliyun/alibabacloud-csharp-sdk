// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCACertificateListRequest : TeaModel {
        /// <summary>
        /// <para>Ca status.</para>
        /// <list type="bullet">
        /// <item><description>issue: inUse.</description></item>
        /// <item><description>forbidden: forbidden.</description></item>
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
        /// <para>The type of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>root: rootCA.</description></item>
        /// <item><description>subRoot: subCA.</description></item>
        /// <item><description>externalCa: import.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>subRoot</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/328095.html">DescribeCACertificateList</a> operation to query the unique identifiers of all CA certificates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>160ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The CA Issuer Type.</para>
        /// <list type="bullet">
        /// <item><description>local: Private certificate.</description></item>
        /// <item><description>iTrusChina: Compliance CA.</description></item>
        /// <item><description>external: External Import.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("IssuerType")]
        [Validation(Required=false)]
        public string IssuerType { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of CA certificates per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>valid time.</para>
        /// <list type="bullet">
        /// <item><description>valid: means in the valid period.</description></item>
        /// <item><description>notValid: means expired.</description></item>
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
