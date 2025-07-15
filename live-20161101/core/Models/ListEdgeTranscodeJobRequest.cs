// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListEdgeTranscodeJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-1</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The keyword of the query.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a task ID for an exact match.</description></item>
        /// <item><description>You can specify a task name for a fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sort order of the tasks by creation time. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order</description></item>
        /// <item><description>asc: ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: not started</description></item>
        /// <item><description>1: running</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The type of edge transcoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>common: standard transcoding and Narrowband HD™ 1.0 transcoding.</description></item>
        /// <item><description>nbhd-2: Narrowband HD™ 2.0 transcoding</description></item>
        /// <item><description>ultra-hd: ultra-high definition transcoding</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the query results are filtered based on the types of edge transcoding on which you are granted permissions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
