// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityScanRunsRequest : TeaModel {
        /// <summary>
        /// <para>The earliest start time of a data quality scan run to include in the results. Specify the time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTimeFrom")]
        [Validation(Required=false)]
        public long? CreateTimeFrom { get; set; }

        /// <summary>
        /// <para>The latest start time of a data quality scan run to include in the results. Specify the time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTimeTo")]
        [Validation(Required=false)]
        public long? CreateTimeTo { get; set; }

        /// <summary>
        /// <para>The ID of the data quality scan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("DataQualityScanId")]
        [Validation(Required=false)]
        public long? DataQualityScanId { get; set; }

        /// <summary>
        /// <para>An object with advanced filter conditions. The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>TaskInstanceId</c>: The ID of the task instance.</para>
        /// </description></item>
        /// <item><description><para><c>RunNumber</c>: The run number of the instance.</para>
        /// </description></item>
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
        /// <para>The page number to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
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
        /// <para>The sort field and order for the results. The format is <c>FieldName Order</c>. The default order is ascending (Asc). Supported fields:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateTime (Desc/Asc)</para>
        /// </description></item>
        /// <item><description><para>Id (Desc/Asc)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The status of the data quality scan run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pass</para>
        /// </description></item>
        /// <item><description><para>Running</para>
        /// </description></item>
        /// <item><description><para>Error</para>
        /// </description></item>
        /// <item><description><para>Fail</para>
        /// </description></item>
        /// <item><description><para>Warn</para>
        /// </description></item>
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
