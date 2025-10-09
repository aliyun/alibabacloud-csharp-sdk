// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityAlertRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data quality monitor that the alert rule targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("DataQualityScanId")]
        [Validation(Required=false)]
        public long? DataQualityScanId { get; set; }

        /// <summary>
        /// <para>The page number of the results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The list of sorting fields. Supports fields such as last modified time and creation time. Format: &quot;SortField+SortOrder (Desc/Asc)&quot;, where Asc is the default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime (Desc/Asc)</description></item>
        /// <item><description>Id (Desc/Asc)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
