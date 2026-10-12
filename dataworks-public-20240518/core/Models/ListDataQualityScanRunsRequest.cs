// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityScanRunsRequest : TeaModel {
        /// <summary>
        /// <para>The earliest start time of the data quality monitoring run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTimeFrom")]
        [Validation(Required=false)]
        public long? CreateTimeFrom { get; set; }

        /// <summary>
        /// <para>The latest start time of the data quality monitoring run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTimeTo")]
        [Validation(Required=false)]
        public long? CreateTimeTo { get; set; }

        /// <summary>
        /// <para>The data quality monitoring ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("DataQualityScanId")]
        [Validation(Required=false)]
        public long? DataQualityScanId { get; set; }

        /// <summary>
        /// <para>The extension query filter. The following filter parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description>TaskInstanceId: the scheduled task instance ID.</description></item>
        /// <item><description>RunNumber: the number of times the instance has run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;TaskInstanceId&quot;: &quot;111&quot;,
        ///     &quot;RunNumber&quot;: &quot;1&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The list of sort fields. Fields such as modification time and creation time are supported. The format is &quot;SortField+SortOrder(Desc/Asc)&quot;. The default value is Asc, which can be omitted. Valid values for the sort field:</para>
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

        /// <summary>
        /// <para>The status of the data quality check result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pass</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Error</description></item>
        /// <item><description>Fail</description></item>
        /// <item><description>Warn</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Fail</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
