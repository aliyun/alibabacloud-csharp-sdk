// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario of the record for acceleration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_video</b>: video and image.</description></item>
        /// <item><description><b>api</b>: API.</description></item>
        /// <item><description><b>web</b>: web page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by whether the record is proxied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The match mode to search for the record name. Default value: exact. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>prefix</b>: match by prefix.</description></item>
        /// <item><description><b>suffix</b>: match by suffix.</description></item>
        /// <item><description><b>exact</b>: exact match.</description></item>
        /// <item><description><b>fuzzy</b>: fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("RecordMatchType")]
        [Validation(Required=false)]
        public string RecordMatchType { get; set; }

        /// <summary>
        /// <para>The record name. This parameter specifies a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The origin type of the record. Only CNAME records can be filtered by using this field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS bucket.</description></item>
        /// <item><description><b>S3</b>: S3 bucket.</description></item>
        /// <item><description><b>LB</b>: load balancer.</description></item>
        /// <item><description><b>OP</b>: origin pool.</description></item>
        /// <item><description><b>Domain</b>: domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The DNS record type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNAME</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
