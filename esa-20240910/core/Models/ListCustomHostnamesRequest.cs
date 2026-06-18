// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCustomHostnamesRequest : TeaModel {
        /// <summary>
        /// <para>The SaaS domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom.site.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The search match mode for the SaaS domain name. Default value: exact. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>prefix</b>: prefix match.</description></item>
        /// <item><description><b>suffix</b>: suffix match.</description></item>
        /// <item><description><b>exact</b>: exact match.</description></item>
        /// <item><description><b>fuzzy</b>: fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exact</para>
        /// </summary>
        [NameInMap("NameMatchType")]
        [Validation(Required=false)]
        public string NameMatchType { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100. Maximum value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The associated record ID. You can call the <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> operation to obtain the record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>744571165985008</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The SaaS domain name status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pending</b>: pending verification.</description></item>
        /// <item><description><b>active</b>: activated.</description></item>
        /// <item><description><b>conflicted</b>: occupied.</description></item>
        /// <item><description><b>offline</b>: offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
