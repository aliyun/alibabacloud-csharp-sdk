// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSyntheticDetailShrinkRequest : TeaModel {
        /// <summary>
        /// <para>An array of filter conditions. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>To query the list of synthetic test results, set this parameter in the following format: [{&quot;Key&quot;:&quot;taskType&quot;,&quot;OpType&quot;:&quot;in&quot;,&quot;Value&quot;:[Task type]}].</description></item>
        /// <item><description>To query the result details of a synthetic monitoring task, set this parameter in the following format: [{&quot;Key&quot;:&quot;dataId&quot;,&quot;OpType&quot;:&quot;eq&quot;,&quot;Value&quot;:&quot;dataId&quot;}]. dataId is returned when you query the list of synthetic test results.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AdvancedFilters")]
        [Validation(Required=false)]
        public string AdvancedFiltersShrink { get; set; }

        /// <summary>
        /// <para>The type of the results. Set the value to SYNTHETIC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNTHETIC</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The type of the list that contains the results. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ICMP_LIST</description></item>
        /// <item><description>TCP_LIST</description></item>
        /// <item><description>DNS_LIST</description></item>
        /// <item><description>HTTP_LIST</description></item>
        /// <item><description>WEBSITE_LIST</description></item>
        /// <item><description>DOWNLOAD_LIST</description></item>
        /// <item><description>ALL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP_LIST</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time of the query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684480557772</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>A reserved field.</para>
        /// </summary>
        [NameInMap("ExactFilters")]
        [Validation(Required=false)]
        public string ExactFiltersShrink { get; set; }

        /// <summary>
        /// <para>The filter condition. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>To query the result of a synthetic monitoring task, set this parameter in the following format: {&quot;taskId&quot;:&quot;${taskId}&quot;}.</description></item>
        /// <item><description>To query the result details of a synthetic monitoring task, set this parameter in the following format: {&quot;taskId&quot;:&quot;${taskId}&quot;,&quot;dataId&quot;:&quot;${dataId}&quot;}.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string FiltersShrink { get; set; }

        /// <summary>
        /// <para>The order in which results are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ASC</c>: ascending order</description></item>
        /// <item><description><c>DESC</c>: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field based on which results are sorted. Set the value to timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timestamp</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region. Set the value to cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timestamp of the start time of the query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684110343127</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The type of the synthetic test. Valid values: 1 and 2. 1 represents an immediate test, and 2 represents a scheduled test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SyntheticType")]
        [Validation(Required=false)]
        public int? SyntheticType { get; set; }

    }

}
