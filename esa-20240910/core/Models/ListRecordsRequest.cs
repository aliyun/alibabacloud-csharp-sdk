// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario for acceleration. Use this parameter to filter results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>image_video</b>: Images and videos.</para>
        /// </description></item>
        /// <item><description><para><b>api</b>: API.</para>
        /// </description></item>
        /// <item><description><para><b>web</b>: Web page.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        [NameInMap("CustomPort")]
        [Validation(Required=false)]
        public string CustomPort { get; set; }

        /// <summary>
        /// <para>The page number. Defaults to <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Defaults to <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters the results based on whether the record is proxied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The record is proxied.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The record is not proxied.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The match type for the record name search. Defaults to <b>exact</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>prefix</b>: Prefix match.</para>
        /// </description></item>
        /// <item><description><para><b>suffix</b>: Suffix match.</para>
        /// </description></item>
        /// <item><description><para><b>exact</b>: Exact match.</para>
        /// </description></item>
        /// <item><description><para><b>fuzzy</b>: Fuzzy match.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("RecordMatchType")]
        [Validation(Required=false)]
        public string RecordMatchType { get; set; }

        /// <summary>
        /// <para>The record name. Use this parameter to filter query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The site ID. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Filters the results by the record\&quot;s origin type. This filter applies only to CNAME records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OSS</b>: OSS origin.</para>
        /// </description></item>
        /// <item><description><para><b>S3</b>: S3 origin.</para>
        /// </description></item>
        /// <item><description><para><b>LB</b>: Load balancer origin.</para>
        /// </description></item>
        /// <item><description><para><b>OP</b>: Origin pool.</para>
        /// </description></item>
        /// <item><description><para><b>Domain</b>: Domain origin.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The DNS record type. Use this parameter to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNAME</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
