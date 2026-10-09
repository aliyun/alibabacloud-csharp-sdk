// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListCertRequest : TeaModel {
        /// <summary>
        /// <para>The host record bound to the certificate, in the YYYY-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-13</para>
        /// </summary>
        [NameInMap("AfterDate")]
        [Validation(Required=false)]
        public string AfterDate { get; set; }

        /// <summary>
        /// <para>The modification time of the certificate, in the YYYY-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-04</para>
        /// </summary>
        [NameInMap("BeforeDate")]
        [Validation(Required=false)]
        public string BeforeDate { get; set; }

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
        /// <para>The UUID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef79512-569b-6a4e-9105-9b91473562f7</para>
        /// </summary>
        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. If this parameter is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The identifier of the intermediate CA that issued the certificate. You can call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifier of a CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273ae6bb538d538c70c01f81jh2****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The total size of the certificate. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The certificate status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ISSUE: Normal.</description></item>
        /// <item><description>REVOKE: Revoked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ISSUE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SERVER: server certificate.</description></item>
        /// <item><description>CLIENT: client certificate.</description></item>
        /// <item><description>END_ENTITY: end-entity certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
