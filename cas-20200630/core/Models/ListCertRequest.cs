// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListCertRequest : TeaModel {
        /// <summary>
        /// <para>Filters certificates modified after this date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-13 12:59:45</para>
        /// </summary>
        [NameInMap("AfterDate")]
        [Validation(Required=false)]
        public string AfterDate { get; set; }

        /// <summary>
        /// <para>Filters certificates modified before this date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-04</para>
        /// </summary>
        [NameInMap("BeforeDate")]
        [Validation(Required=false)]
        public string BeforeDate { get; set; }

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
        /// <para>The token used to retrieve the next page of results. This is the NextToken value from a previous response. If unspecified, the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The identifier of the intermediate CA that issued the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273ae6bb538d538c70c01f81jh2****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The page size. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ISSUE: Active</para>
        /// </description></item>
        /// <item><description><para>REVOKE: Revoked</para>
        /// </description></item>
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
        /// <item><description><para>SERVER: Server certificate</para>
        /// </description></item>
        /// <item><description><para>CLIENT: Client certificate</para>
        /// </description></item>
        /// <item><description><para>END_ENTITY: End-entity certificate</para>
        /// </description></item>
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
