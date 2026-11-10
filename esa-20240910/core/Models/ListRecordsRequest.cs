// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario for record acceleration. This parameter is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_video</b>: images and videos</description></item>
        /// <item><description><b>api</b>: APIs</description></item>
        /// <item><description><b>web</b>: web pages</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>Specifies whether a custom port is enabled for the record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled</description></item>
        /// <item><description>off: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CustomPort")]
        [Validation(Required=false)]
        public string CustomPort { get; set; }

        /// <summary>
        /// <para>The page number for paging. The value must be greater than or equal to 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Valid values: 1 to 500. Default value: <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether proxy acceleration is enabled for the record. This parameter is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Proxy acceleration is enabled.</description></item>
        /// <item><description><b>false</b>: Proxy acceleration is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The search match mode for the record name. Default value: exact. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>prefix</b>: prefix match</description></item>
        /// <item><description><b>suffix</b>: suffix match</description></item>
        /// <item><description><b>exact</b>: exact match</description></item>
        /// <item><description><b>fuzzy</b>: fuzzy match</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("RecordMatchType")]
        [Validation(Required=false)]
        public string RecordMatchType { get; set; }

        /// <summary>
        /// <para>The record name. This parameter is used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain the site ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The origin server type of the record. This parameter is used as a filter condition for the query. Only CNAME records can be filtered by this field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS origin server</description></item>
        /// <item><description><b>S3</b>: S3 origin server</description></item>
        /// <item><description><b>LB</b>: load balancing origin server</description></item>
        /// <item><description><b>OP</b>: IPAM pool origin server</description></item>
        /// <item><description><b>Domain</b>: regular domain name origin server</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The DNS record type of the record. This parameter is used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNAME</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
