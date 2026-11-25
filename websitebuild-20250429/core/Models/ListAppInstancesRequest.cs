// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The application type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PC_WebSite: web application.</description></item>
        /// <item><description>Mini_Program: mini program.
        /// If this parameter is not specified or is left empty, no filtering by type is performed. Historical missing, NULL, or empty types are compatible with PC_WebSite.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PC_WebSite</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The list of business IDs for the application instances.</para>
        /// </summary>
        [NameInMap("BizIds")]
        [Validation(Required=false)]
        public List<string> BizIds { get; set; }

        /// <summary>
        /// <para>Used only in the CONTENT_CREATION pattern: exact match for the fully attached domain name, mutually exclusive with Query. It does not include the protocol, port, or path.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The expiration start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-18T14:30:00Z</para>
        /// </summary>
        [NameInMap("EndTimeBegin")]
        [Validation(Required=false)]
        public string EndTimeBegin { get; set; }

        /// <summary>
        /// <para>The expiration end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-31T14:30:00Z</para>
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The maximum number of results per query.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. It is empty when there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh3BFw8paIJ7ylB6A7Qn9JjM</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreated</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values: ASC and DESC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOWNGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RequestId&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The query mode. CONTENT_CREATION indicates a lightweight query for the content creation site selector, which queries only published sites and does not load aggregate information such as Profile, services, or AI Staff.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTENT_CREATION</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The status scope.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
