// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListTransportLayerApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The query type for the host record of Layer 4 applications. The following four types are supported, and the default is exact match.</para>
        /// <list type="bullet">
        /// <item><description>fuzzy: Fuzzy match.</description></item>
        /// <item><description>exact: Exact match.</description></item>
        /// <item><description>prefix: Prefix match.</description></item>
        /// <item><description>suffix: Suffix match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The page number for paginated queries. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paginated queries. Valid values: 1-500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The host record of the Layer 4 application.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>Site ID. You can obtain it by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456******</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
