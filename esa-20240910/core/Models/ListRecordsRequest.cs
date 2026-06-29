// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario for record acceleration. Used as a filter condition for queries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_video</b>: Image and video.</description></item>
        /// <item><description><b>api</b>: API.</description></item>
        /// <item><description><b>web</b>: Web page.</description></item>
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
        /// <para>The page number for paginated queries. The value must be greater than or equal to 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paginated queries. Valid values: 1 to 500. Default value: <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether proxy acceleration is enabled for the record. Used as a filter condition for queries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Proxy enabled.</description></item>
        /// <item><description><b>false</b>: Proxy acceleration disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The search matching mode for record names. Defaults to exact match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>prefix</b>: Prefix match.</description></item>
        /// <item><description><b>suffix</b>: Suffix match.</description></item>
        /// <item><description><b>exact</b>: Exact match.</description></item>
        /// <item><description><b>fuzzy</b>: Fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("RecordMatchType")]
        [Validation(Required=false)]
        public string RecordMatchType { get; set; }

        /// <summary>
        /// <para>Record name. Used as a filter condition for queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The origin type of the record. Used as a filter condition for queries (only CNAME records can be filtered by this field). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS origin.</description></item>
        /// <item><description><b>S3</b>: S3 origin.</description></item>
        /// <item><description><b>LB</b>: Load balancer origin.</description></item>
        /// <item><description><b>OP</b>: Origin pool.</description></item>
        /// <item><description><b>Domain</b>: Standard domain origin.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The DNS record type of the record. Used as a filter condition for queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNAME</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
